
using Pokemon.Interface;
using Pokemon.Models;
using Pokemon.Util;


namespace Pokemon.Options;
internal class ShowPokemon : Ioption
{
    public string Name { get; set; } = "mostra o pokemon escolhido";
    public string? _pokemonUrl { get; set; }
    public int tipo { get; set; }


    public new void Function()
    {
        _pokemonUrl = "request";
        return;
    }

    public static void ProtocolMain(PokemonModel x)
    {
        Console.Clear();
        Console.WriteLine($"nome: {x.Name}");
        Console.WriteLine($"aparencia: {x.sprites.FrontDefault}");
        Console.WriteLine($"altura: {x.height}");
        Console.WriteLine($"peso: {x.weight}");
        Console.Write("tipos: ");
        foreach (var i in x.types)
        {
            Console.Write($"{i.type.Name} ");
        }
        Console.WriteLine();
        Console.WriteLine($"humor: {DefineStatus.mainstatus(x.mood, "humor")}");
        Console.WriteLine($"fome: {DefineStatus.mainstatus(x.Hungry, "fome")}");
        Console.WriteLine($"sono: {DefineStatus.mainstatus(x.Sleep, "descanso")}");

        Console.WriteLine();
    }

}

