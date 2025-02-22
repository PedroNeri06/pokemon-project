
using Pokemon.Interface;
using Pokemon.Controllers;
using Pokemon.Models;
using Pokemon.Util;

namespace Pokemon.Options;

internal class PlayWithPokemon : Ioption
{
    public string Name { get; set; } = "brincar com seu pokemon";
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
                    Console.WriteLine("seu pokemon ja está muito feliz");
                }
                else if (x.Sleep <= 10 && x.Hungry <= 10)
                {
                    x.mood = x.mood + 5;
                    x.Sleep = 0;
                    x.Hungry = 0;
                    Console.WriteLine("você alimentou seu pokemon");
                    Console.WriteLine($"{DefineStatus.mainstatus(x.mood, "humor")}");
                    Console.WriteLine($"{DefineStatus.mainstatus(x.Sleep, "descanso")}");
                    Console.WriteLine($"{DefineStatus.mainstatus(x.Hungry, "fome")}");
                }
                x.mood = x.mood + 5;
                x.Sleep = x.Sleep - 10;
                x.Hungry = x.Hungry - 10;
                Console.WriteLine("você alimentou seu pokemon");
                Console.WriteLine($"{DefineStatus.mainstatus(x.mood, "humor")}");
                Console.WriteLine($"{DefineStatus.mainstatus(x.Sleep, "sono")}");
                Console.WriteLine($"{DefineStatus.mainstatus(x.Hungry, "fome")}");
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("pokemon invalido");
                return;
            }
        }
        Console.WriteLine($"você ainda não escolheu um pokemon digite uma tecla para volta");
        Console.ReadKey();
        return;
    }
}
