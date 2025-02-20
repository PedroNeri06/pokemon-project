using Pokemon.Interface;
using Pokemon.Object;
using Pokemon.Options;

namespace Pokemon.Modules;

internal class Main
{
    public Main(Client client, Options options)
    {
        _client = client;
        _options = options;
    }
    private Client _client;
    private Options _options;
    private PokemonReal _PokemonUrl;

    public void MenuOptions()
    {
        Console.Clear();
        _options.ShowOption();
        List<Ioption> UrlNotNull = _options.options.Where(x => x._pokemonUrl != "").Select(x => x).ToList();
        for (int x = 0; x != UrlNotNull.Count(); x++)
        {
            if (UrlNotNull[x]._pokemonUrl == "request")
            {

                UrlNotNull[x].Function();
                ShowPokemon.ProtocolMain(_PokemonUrl);
                Console.ReadKey();
                UrlNotNull[x]._pokemonUrl = "";
            }
            else
            {
                _client.Connect(UrlNotNull[x]._pokemonUrl!);
                _PokemonUrl = _client.pokemonClient;
                UrlNotNull[x]._pokemonUrl = "";

            }
        }
        MenuOptions();
        Console.Clear();

    }
}