namespace SunamoInterfaces.Interfaces;

// Interface for browser control operations.
// The Control class depends on the type of target application.
// Used in:
// - SunamoCef/CefBrowser
// - WebSunamo/SunamoBrowser
// - UniversalWebControl/SunamoBrowser
public interface ISunamoBrowser
{
    Uri Source { get; set; }

    string HTML { get; }

    // Must be Task due to UWP! Much time spent with this on GeoCachingTool.
    Task<HtmlDocument> GetHtmlDocument();

    // Sometimes getting outer HTML is quite slow, so put await Task.Delay(500) before calling GetContent().
    // Remember for troubles with GeoCachingTool.
    Task<string> GetContent();

    void Navigate(string uri);

    bool ScrollToEnd();

    void Init();
}
