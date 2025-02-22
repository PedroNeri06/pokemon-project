using System.Reflection.Metadata.Ecma335;

namespace Pokemon.Util;

internal class DefineStatus
{
    static public string mainstatus(int status, string name)
    {
        if (status <= 0 && 30 >= status)
        {
            return $"seu pokemon está com {name} baixo";
        }
        else if (status <= 31 && 70 >= status)
        {
            return $"seu pokemon está com {name} bom";
        }
        else if (status <= 71 && 100 >= status)
        {
            return $"seu pokemon está com {name} muito bom";
        }
        return "status alterado";
    }
}