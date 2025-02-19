using System.Text.Json.Serialization;
using Pokemon.Interface;

namespace Pokemon.Object;
public class Sprites : Isprites
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; }
}