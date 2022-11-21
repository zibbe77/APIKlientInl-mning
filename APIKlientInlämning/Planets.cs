using System;
using System.Text.Json.Serialization;

public class Planets
{

    public string name { get; set; }
    public string climate { get; set; }
    public string diameter { get; set; }
    public string gravity { get; set; }

    [JsonPropertyName("orbital_period")]
    public string orbitalPeriod { get; set; }
    public string population { get; set; }
    public string[] residents { get; set; }


    [JsonPropertyName("rotation_period")]
    public string rotationPeriod { get; set; }
    [JsonPropertyName("surface_water")]
    public string surfaceWater { get; set; }
    public string terrain { get; set; }

}
