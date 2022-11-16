using RestSharp;
using System.Text.Json;

RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest request = new RestRequest("pokemon/charmander");
RestResponse response = pokeClient.GetAsync(request).Result;
