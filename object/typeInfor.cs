using System.Text.Json.Serialization;
using Pokemon.Interface;

namespace Pokemon.Object;

public class TypeInfo : ItypeInfor
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}
