namespace SunamoInterfaces._public.SunamoArgs;

/// <summary>
/// Represents the validate data type.
/// </summary>
public class ValidateData
{
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly ValidateData Default = new();

    /// <summary>
    /// Gets or sets the is allowing empty.
    /// </summary>
    public bool IsAllowingEmpty { get; set; } = false;

    /// <summary>
    /// Gets or sets the excluded strings.
    /// </summary>
    public List<string> ExcludedStrings { get; set; } = new();

    /// <summary>
    /// Gets or sets the message to really show.
    /// </summary>
    public string? MessageToReallyShow { get; set; }

    /// <summary>
    /// Gets or sets the message when validate method fails.
    /// </summary>
    public string? MessageWhenValidateMethodFails { get; set; } = null;

    /// <summary>
    /// Gets or sets the is trimming.
    /// </summary>
    public bool IsTrimming { get; set; } = true;

    /// <summary>
    /// Gets or sets the validate method.
    /// </summary>
    public Func<string, bool>? ValidateMethod { get; set; }
}
