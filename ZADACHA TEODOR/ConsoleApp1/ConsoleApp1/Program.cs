using Newtonsoft.Json.Linq;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        var json = new WebClient().DownloadString(
            "https://api.open-meteo.com/v1/forecast?latitude=42.1354&longitude=24.7453&current_weather=true");

        var w = JObject.Parse(json)["current_weather"];

        Console.WriteLine("Vremeto v Plovdiv");
        Console.WriteLine("------------------");
        Console.WriteLine($"Temperature: {w["temperature"]}°C");
        Console.WriteLine($"Wind: {w["windspeed"]} km/h");
    }
}
