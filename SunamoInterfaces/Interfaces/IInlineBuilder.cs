namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for building inline formatted text elements.
/// </summary>
public interface IInlineBuilder
{
    /// <summary>
    /// Adds bold text.
    /// </summary>
    /// <param name="text">The text to make bold.</param>
    void Bold(string text);

    /// <summary>
    /// Adds a bullet point with text.
    /// </summary>
    /// <param name="text">The bullet text.</param>
    void Bullet(string text);

    /// <summary>
    /// Adds an error message.
    /// </summary>
    /// <param name="errorMessage">The error message to display.</param>
    void Error(string errorMessage);

    /// <summary>
    /// Adds a level 1 heading.
    /// </summary>
    /// <param name="text">The heading text.</param>
    void H1(string text);

    /// <summary>
    /// Adds a level 1 heading with maximum width constraint.
    /// </summary>
    /// <param name="text">The heading text.</param>
    /// <param name="maxWidth">The maximum width for the heading.</param>
    void H1(string text, double maxWidth);

    /// <summary>
    /// Adds a level 2 heading.
    /// </summary>
    /// <param name="text">The heading text.</param>
    void H2(string text);

    /// <summary>
    /// Adds a level 3 heading.
    /// </summary>
    /// <param name="text">The heading text.</param>
    void H3(string text);

    /// <summary>
    /// Adds a hyperlink.
    /// </summary>
    /// <param name="text">The link text to display.</param>
    /// <param name="uri">The URI to link to.</param>
    void Hyperlink(string text, string uri);

    /// <summary>
    /// Adds italic text.
    /// </summary>
    /// <param name="text">The text to make italic.</param>
    void Italic(string text);

    /// <summary>
    /// Adds a key-value pair.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    void KeyValue(string key, string value);

    /// <summary>
    /// Adds a line break.
    /// </summary>
    void LineBreak();

    /// <summary>
    /// Adds a run of plain text.
    /// </summary>
    /// <param name="text">The text to add.</param>
    void Run(string text);
}