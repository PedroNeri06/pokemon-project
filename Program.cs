using Pokemon.Controllers;
using Pokemon.Interface;
using Pokemon.Options;

Ioption option1 = new SelectPokemon();
Ioption option2 = new ShowPokemon();
Ioption option3 = new SleepPokemon();
Ioption option4 = new FeedsPokemon();
Ioption option5 = new PlayWithPokemon();

OptionsControl options = new OptionsControl();

options.AddOption(option1);
options.AddOption(option2);
options.AddOption(option3);
options.AddOption(option4);
options.AddOption(option5);

ClientControl client = new ClientControl();

MainControl main = new MainControl(client, options);

try { main.MenuOptions(); } catch { Console.WriteLine("você saiu do programa"); }
