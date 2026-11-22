namespace SunamoInterfaces._public.SunamoArgs;

/// <summary>
/// Represents the external login result type.
/// </summary>
public class ExternalLoginResult
{
    /// <summary>
    /// Gets or sets the user id.
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Gets or sets the session cookie.
    /// </summary>
    public string? SessionCookie { get; set; }

    /// <summary>
    /// Gets or sets the parameter 1.
    /// </summary>
    public string? Parameter1 { get; set; }
}
