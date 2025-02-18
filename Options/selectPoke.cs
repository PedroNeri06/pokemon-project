using System.Reflection.Metadata.Ecma335;
using Pokemon.Interface;

namespace Pokemon.Options;

internal class SelectPokemon : Ioption
{
    public string Name { get; set; } = "selecionar pokemon";
    public string? _pokemonUrl { get; set; } = "";

    public void Function()
    {
        Console.WriteLine("Digite o nome de um Pokemon valido");
        string pokemon = Console.ReadLine()!;
        this._pokemonUrl = $"https://pokeapi.co/api/v2/pokemon/{pokemon}";
        return;

    }
}