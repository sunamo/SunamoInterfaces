namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i dump as string type.
/// </summary>
public interface IDumpAsString
{
    /// <summary>
    /// Dump as string.
    /// </summary>
    /// <param name="operation">The operation.</param>
    /// <param name="headerArgs">The header args.</param>
    /// <returns>The dump as string result.</returns>
    string DumpAsString(string operation, object headerArgs);
}
