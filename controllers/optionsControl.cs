namespace Pokemon.Controllers;
using Pokemon.Interface;

internal class OptionsControl
{
    public List<Ioption> options = new List<Ioption>();
    public void AddOption(Ioption op)
    {
        Console.WriteLine(op.Name);
        options.Add(op);
        return;
    }
    public void ShowOption()
    {

        Console.WriteLine("__Menu__");
        for (int x = 0; x != options.Count(); x++)
        {
            Console.WriteLine($"{x + 1} - {options[x].Name}");
        }
        Console.WriteLine("selecione uma opção digitando o numero da opção: ");
        string optionString = Console.ReadLine()!;
        int option = int.Parse(optionString);
        this.SelectOption(option);


        return;
    }

    public void SelectOption(int option)
    {
        options[option - 1].Function();

    }
};