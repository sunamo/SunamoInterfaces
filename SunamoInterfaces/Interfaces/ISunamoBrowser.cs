namespace SunamoInterfaces.Interfaces;

/// <summary>
///     A1 je třída Control závislá na typu cílové aplikace
///     Is used in :
///     SunamoCef/CefBrowser
///     WebSunamo/SunamoBrowser
///     UniversalWebControl/SunamoBrowser
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ISunamoBrowser
{
    Uri Source { get; set; }

    string HTML { get; }

    /// <summary>
    ///     Must be Task due to UWP!
    ///     Much time spent with it on GeoCachingTool!
    /// </summary>
    Task<HtmlDocument> GetHtmlDocument();

    /// <summary>
    ///     Sometimes is getting outer html quite slow so put await Task.Delay(500); before calling GetContent()
    ///     Remember for troubles with GeoCachingTool
    /// </summary>
    Task<string> GetContent();

    void Navigate(string uri);
    bool ScrollToEnd();
    void Init();
}