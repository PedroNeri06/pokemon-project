using System.Text.Json.Serialization;

namespace Pokemon.Models;
public class SpritesModel
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; }
}