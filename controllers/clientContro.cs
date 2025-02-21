using System.Text.Json;
using Pokemon.Models;
using RestSharp;

namespace Pokemon.Controllers;
internal class ClientControl
{
    public PokemonModel pokemonClient { get; set; }
    public void Connect(string url)
    {
        try
        {
            using (var request = new RestClient($"{url}"))
            {
                var client = new RestRequest("", Method.Get);
                var result = request.Execute(client);
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var pokemon = JsonSerializer.Deserialize<PokemonModel>(result.Content!);
                    pokemonClient = pokemon!;

                }
                else
                {
                    Console.WriteLine("pokemon invalido");
                }

            }
        }
        catch
        {
            Console.WriteLine("Erro");
        }

    }
}