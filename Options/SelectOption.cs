
using Pokemon.Interface;
using Pokemon.Controllers;
using Pokemon.Models;

namespace Pokemon.Options;

internal class SelectPokemon : Ioption
{
    public string Name { get; set; } = "selecionar pokemon";
    public new string? _pokemonUrl { get; set; } = "";
    public PokemonModel _pokemon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Function()
    {
        try
        {
            Console.WriteLine("Digite o nome de um Pokemon valido");
            string pokemon = Console.ReadLine()!;
            ClientControl client = new ClientControl();
            Ioption show = new ShowPokemon();
            client.Connect($"https://pokeapi.co/api/v2/pokemon/{pokemon}");
            ShowPokemon.ProtocolMain(client.pokemonClient);
            Console.WriteLine("tem certeza que quer escolhe este pokemon ? \n (digite y para sim e n para não)");
            string choose = Console.ReadLine()!;
            switch (choose)
            {
                case "y":
                    {
                        this._pokemonUrl = $"https://pokeapi.co/api/v2/pokemon/{pokemon}";
                    }
                    break;
                case "n":
                    {
                        Console.Clear();
                        Function();
                    }
                    break;
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("resposta invalida digite qualque tecla para continua");
                        Console.ReadKey();
                    }
                    break;
            }

        }
        catch
        {
            Console.Clear();
            Console.WriteLine("pokemon invalido");
            return;
        }
        return;
    }
}
