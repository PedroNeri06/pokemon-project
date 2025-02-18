using Pokemon.Modules;
using Pokemon.Options;
using RestSharp;

Options menu = new Options();
SelectPokemon option1 = new SelectPokemon();

menu.AddOption(option1);
menu.ShowOption();
using (var request = new RestClient($"{option1._pokemonUrl}"))
{
    var client = new RestRequest("", Method.Get);
    var result = request.Execute(client);
    if (result.StatusCode == System.Net.HttpStatusCode.OK)
    {
        Console.WriteLine(result.Content);
    }
    else
    {
        Console.WriteLine("pokemon invalido");
    }


}
