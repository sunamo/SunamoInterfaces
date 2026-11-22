namespace SunamoInterfaces.Interfaces;

// Interface for browser control operations.
// The Control class depends on the type of target application.
// Used in:
// - SunamoCef/CefBrowser
// - WebSunamo/SunamoBrowser
// - UniversalWebControl/SunamoBrowser
/// <summary>
/// Represents the i sunamo browser type.
/// </summary>
public interface ISunamoBrowser
{
    /// <summary>
    /// Gets or sets the source.
    /// </summary>
    Uri Source { get; set; }

    /// <summary>
    /// Gets the HTML.
    /// </summary>
    string HTML { get; }

    // Must be Task due to UWP! Much time spent with this on GeoCachingTool.
    /// <summary>
    /// Get html document.
    /// </summary>
    /// <returns>The get html document result.</returns>
    Task<HtmlDocument> GetHtmlDocument();

    // Sometimes getting outer HTML is quite slow, so put await Task.Delay(500) before calling GetContent().
    // Remember for troubles with GeoCachingTool.
    /// <summary>
    /// Get content.
    /// </summary>
    /// <returns>The get content result.</returns>
    Task<string> GetContent();

    /// <summary>
    /// Navigate.
    /// </summary>
    /// <returns>The navigate result.</returns>
    void Navigate(string uri);

    /// <summary>
    /// Scroll to end.
    /// </summary>
    /// <param name="500">The 500.</param>
    /// <returns>The scroll to end result.</returns>
    bool ScrollToEnd();

    /// <summary>
    /// Init.
    /// </summary>
    /// <returns>The init result.</returns>
    void Init();
}
