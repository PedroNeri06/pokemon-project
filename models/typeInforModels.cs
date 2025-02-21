using System.Text.Json.Serialization;
namespace Pokemon.Models;

public class TypeInfoModel
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}
