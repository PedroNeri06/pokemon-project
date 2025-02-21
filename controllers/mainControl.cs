using Pokemon.Interface;
using Pokemon.Models;
using Pokemon.Options;

namespace Pokemon.Controllers;

internal class MainControl
{
    public MainControl(ClientControl client, OptionsControl options)
    {
        _client = client;
        _options = options;
    }
    private ClientControl _client;
    private OptionsControl _options;
    private PokemonModel _PokemonUrl;

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