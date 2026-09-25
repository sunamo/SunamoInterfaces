namespace SunamoInterfaces._public.SunamoArgs;

/// <summary>
/// Represents the result of an external login operation.
/// </summary>
public class ExternalLoginResult
{
    /// <summary>
    /// Gets or sets the user identifier.
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Gets or sets the session cookie.
    /// </summary>
    public string? SessionCookie { get; set; }

    /// <summary>
    /// Gets or sets an additional parameter.
    /// </summary>
    public string? Parameter1 { get; set; }
}