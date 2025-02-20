using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using Pokemon.Object;

namespace Pokemon.Interface;
internal interface Ioption
{
    public string Name { get; set; }
    public string? _pokemonUrl { get; set; }
    public void Function();

}