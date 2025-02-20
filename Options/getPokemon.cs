
using Pokemon.Interface;
using Pokemon.Object;


namespace Pokemon.Options;
internal class ShowPokemon : Ioption
{
    public string Name { get; set; } = "mostra o pokemon escolhido";
    public new string? _pokemonUrl { get; set; }
    PokemonReal _pokemon { get; set; }
    public new void Function()
    {
        _pokemonUrl = "request";
        return;
    }

    public static void ProtocolMain(PokemonReal x)
    {
        Console.WriteLine(x.Name);
        Console.WriteLine(x.sprites.FrontDefault);
        Console.WriteLine(x.height);
        Console.WriteLine(x.weight);
        Console.WriteLine(x.types[0].Type.Name);
    }
}

