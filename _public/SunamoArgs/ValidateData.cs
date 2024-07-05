namespace SunamoInterfaces._public.SunamoArgs;





public class ValidateData
{
    public static readonly ValidateData Default = new ValidateData();
    public bool allowEmpty = false;
    
    
    
    public List<string> excludedStrings = new List<string>();
    public string messageToReallyShow;
    public string messageWhenValidateMethodFails = null;
    public bool trim = true;
    public Func<string, bool> validateMethod;
    
    
    public int ValidateNotInline()
    {
        int i = 0;
        return i;
    }
}