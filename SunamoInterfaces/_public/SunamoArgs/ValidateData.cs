namespace SunamoInterfaces._public.SunamoArgs;

/// <summary>
/// Configuration for data validation operations.
/// </summary>
public class ValidateData
{
    /// <summary>
    /// Gets the default validation configuration.
    /// </summary>
    public static readonly ValidateData Default = new();

    /// <summary>
    /// Gets or sets a value indicating whether empty values are allowed.
    /// </summary>
    public bool IsAllowingEmpty { get; set; } = false;

    /// <summary>
    /// Gets or sets the list of strings to exclude from validation.
    /// </summary>
    public List<string> ExcludedStrings { get; set; } = new();

    /// <summary>
    /// Gets or sets the message to actually show to the user.
    /// </summary>
    public string? MessageToReallyShow { get; set; }

    /// <summary>
    /// Gets or sets the message to show when validation method fails.
    /// </summary>
    public string? MessageWhenValidateMethodFails { get; set; } = null;

    /// <summary>
    /// Gets or sets a value indicating whether to trim whitespace before validation.
    /// </summary>
    public bool IsTrimming { get; set; } = true;

    /// <summary>
    /// Gets or sets the custom validation method function.
    /// </summary>
    public Func<string, bool>? ValidateMethod { get; set; }
}