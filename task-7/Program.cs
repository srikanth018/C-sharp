using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

public class WeatherObject
{
    public string? name { get; set; }
    public Main? main { get; set; }

    public Weather[]? weather { get; set; }
}

public class Main
{
    public double? temp { get; set; }
    public double? humidity { get; set; }
}

public class Weather
{
    public string? description { get; set; }
}
class Program
{

    static async Task FetchData(string city, string api)
    {

        using HttpClient http = new HttpClient();

        try
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&APPID={api}";
            HttpResponseMessage response = await http.GetAsync(url);
            
            System.Console.WriteLine("Fetching data");
            Task.Delay(2000).Wait();
            string json = await response.Content.ReadAsStringAsync();


            WeatherObject? weather = JsonSerializer.Deserialize<WeatherObject>(json);

            System.Console.WriteLine("Location : " + weather?.name);
            double? temperature = weather?.main?.temp - 273.15;
            System.Console.WriteLine($"Temperature : {temperature}C");
            System.Console.WriteLine($"Humidity : {weather?.main?.humidity}");
            System.Console.WriteLine($"Info : {weather?.weather?[0].description}");

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }

    }
    static async Task Main()
    {
        Console.WriteLine("Enter the city name");
        string? city = Console.ReadLine();

        string api = "25ae8ad5ba384384be2a28510092f7cb";

        await FetchData(city, api);

    }


}