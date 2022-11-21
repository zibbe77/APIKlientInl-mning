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
    #region Deserilaze

    Planets p = JsonSerializer.Deserialize<Planets>(response.Content);

    #endregion
    #region Reflections 

    Type _type;
    _type = typeof(Planets);
    var properties = _type.GetProperties();

    foreach (var e in properties)
    {
        System.Console.WriteLine(e);
    }
    Console.ReadLine();

    #endregion
}