
# Task 7: Asynchronous Programming and Multi-threading

## Task Objective:
- Develop a console application that performs multiple asynchronous operations concurrently.
- Use `async` and `await` to fetch data from multiple simulated sources (e.g., using `Task.Delay` to mimic API calls).
- Aggregate the results once all tasks are complete.
- Handle exceptions that may occur during asynchronous operations.

##  How It Works:

1. **User Input**:  
   The application starts by asking the user to enter the name of a city.

2. **Async Weather Fetch**:  
   The core functionality is an asynchronous method `FetchData`, which:
   - Calls the **OpenWeatherMap API** with the provided city and API key.
   - Awaits the response using `HttpClient.GetAsync`.
   - Deserializes the **JSON response** into a `WeatherObject`.

3. **Artificial Delay**:  
   A `Task.Delay(2000)` is added to simulate a delay (like real-world API latency), giving a realistic async feel.

4. **Data Display**:  
   Once the data is received:
   - The **location name** is shown.
   - Temperature is converted from **Kelvin to Celsius**.
   - **Humidity** and **weather description** are displayed.

5. **Error Handling**:  
   The operation is enclosed in a `try-catch` block to ensure any failures (e.g., network issues, invalid city names) are properly handled and the error message is displayed.

---

##  Sample Input & Output:

### User Input and Console Output:

```
Enter the city name
salem

Fetching data
Location : Salem
Temperature : 35.65C
Humidity : 28
Info : overcast clouds
```
