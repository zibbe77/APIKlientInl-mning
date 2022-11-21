using RestSharp;
using System.Text.Json;
using System.Reflection;

RestClient pokeClient = new RestClient("https://swapi.py4e.com/api/");
RestRequest request = new RestRequest("/planets/30");
RestResponse response = pokeClient.GetAsync(request).Result;


Console.WriteLine(response.IsSuccessful);
Thread.Sleep(300);

if (response.IsSuccessful)
{
    Planets p = JsonSerializer.Deserialize<Planets>(response.Content);

    Planets Planets = new Planets();

    PropertyInfo[] properties = typeof(Planets).GetProperties();
    foreach (PropertyInfo property in properties)
    {
        Console.WriteLine(property.Module);

        Console.WriteLine("");
    }
    Console.ReadLine();
}