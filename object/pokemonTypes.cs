using System.Text.Json.Serialization;
using Pokemon.Interface;

namespace Pokemon.Object;
public class PokeType : IpokeType

{

    [JsonPropertyName("slot")]
    public int Slot { get; set; }

    [JsonPropertyName("type")]
    public TypeInfo Type { get; set; }

}