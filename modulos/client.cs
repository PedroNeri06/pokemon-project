using System.IO.Pipes;
using System.Text.Json;
using RestSharp;

namespace Pokemon.Object;
internal class Client
{
    public PokemonReal pokemonClient { get; set; }
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
                    var pokemon = JsonSerializer.Deserialize<PokemonReal>(result.Content!);
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