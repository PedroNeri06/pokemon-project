
using Pokemon.Interface;
using Pokemon.Modules;
using Pokemon.Object;
using Pokemon.Options;

Ioption oprion1 = new SelectPokemon();
Ioption oprion2 = new ShowPokemon();

Options options = new Options();

options.AddOption(oprion1);
options.AddOption(oprion2);
Client client = new Client();

Main main = new Main(client, options);

main.MenuOptions();
