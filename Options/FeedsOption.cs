
using Pokemon.Interface;
using Pokemon.Controllers;
using Pokemon.Models;
using Pokemon.Util;

namespace Pokemon.Options;

internal class FeedsPokemon : Ioption
{
    public string Name { get; set; } = "alimentar seu pokemon";
    public new string? _pokemonUrl { get; set; } = "";

    public new void Function()
    {
        _pokemonUrl = "request";
        return;
    }

    public static void ProtocolMain(PokemonModel x)
    {
        if (x.Name != null)
        {
            try
            {
                if (x.Hungry == 100)
                {
                    Console.WriteLine("seu pokemon ja está alimentado");
                }
                x.Hungry = x.Hungry + 5;
                Console.WriteLine("você alimentou seu pokemon");
                Console.WriteLine($"{DefineStatus.mainstatus(x.Hungry, "fome")}");
                Console.ReadKey();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("erro");
                return;
            }
        }
        Console.WriteLine($"você ainda não escolheu um pokemon");
        Console.ReadKey();
        return;
    }
}
