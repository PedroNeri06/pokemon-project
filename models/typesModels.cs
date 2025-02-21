using System.Text.Json.Serialization;
namespace Pokemon.Models;
public class TypeModel

{

    [JsonPropertyName("slot")]
    public int slot { get; set; }

    [JsonPropertyName("type")]
    public TypeInfoModel type { get; set; }
}