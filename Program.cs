using Pokemon.Controllers;
using Pokemon.Interface;
using Pokemon.Options;

Ioption option1 = new SelectPokemon();
Ioption option2 = new ShowPokemon();

OptionsControl options = new OptionsControl();

options.AddOption(option1);
options.AddOption(option2);
ClientControl client = new ClientControl();

MainControl main = new MainControl(client, options);

try { main.MenuOptions(); } catch { Console.WriteLine("você saiu do programa"); }
