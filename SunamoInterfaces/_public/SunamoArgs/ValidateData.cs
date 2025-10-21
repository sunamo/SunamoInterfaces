// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoInterfaces._public.SunamoArgs;

public class ValidateData
{
    public static readonly ValidateData Default = new();
    public bool allowEmpty = false;


    public List<string> excludedStrings = new();
    public string messageToReallyShow;
    public string messageWhenValidateMethodFails = null;
    public bool trim = true;
    public Func<string, bool> validateMethod;


    public int ValidateNotInline()
    {
        var i = 0;
        return i;
    }
}