namespace ECommerce.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionHandlingMiddleware> logger;
        private readonly string logFilePath;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
            logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
        }

        public async Task Invoke(HttpContext context)
        {
            var originalBodyStream = context.Response.Body;

            using var memoryStream = new MemoryStream();
            context.Response.Body = memoryStream;

            try
            {
                await next(context);

                memoryStream.Seek(0, SeekOrigin.Begin);
                var responseBody = await new StreamReader(memoryStream).ReadToEndAsync();

                if (context.Response.StatusCode >= 400)
                {
                    var logmsg = $"[{DateTime.Now}] Error occured: {context.Request.Method} {context.Request.Path}\n{responseBody}\n";
                    await File.AppendAllTextAsync(logFilePath, logmsg);
                }
                else if (context.Response.StatusCode >= 200 && context.Response.StatusCode < 300)
                {
                    var logmsg = $"[{DateTime.Now}] Request Completed Successfully {context.Request.Method} {context.Request.Path}\n";
                    await File.AppendAllTextAsync(logFilePath, logmsg);
                }

                // Copy content back to original response stream
                memoryStream.Seek(0, SeekOrigin.Begin);
                await memoryStream.CopyToAsync(originalBodyStream);
            }
            catch (Exception e)
            {
                var logmsg = $"[{DateTime.Now}] Error Occurred: {context.Request.Method} {context.Request.Path} {e.Message} {e}\n";
                await File.AppendAllTextAsync(logFilePath, logmsg);

            }
            finally
            {
                context.Response.Body = originalBodyStream; // restore original stream
            }
        }
    }

}
