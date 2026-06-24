namespace SunamoInterfaces._public.SunamoArgs;

public class ValidateData
{
    public static readonly ValidateData Default = new();

    public bool IsAllowingEmpty { get; set; } = false;

    public List<string> ExcludedStrings { get; set; } = new();

    public string? MessageToReallyShow { get; set; }

    public string? MessageWhenValidateMethodFails { get; set; } = null;

    public bool IsTrimming { get; set; } = true;

    public Func<string, bool>? ValidateMethod { get; set; }
}
