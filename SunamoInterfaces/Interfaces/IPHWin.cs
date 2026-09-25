namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for Windows process helper.
/// This should be implemented as a class with an Init method.
/// </summary>
public interface IPHWin
{
    /// <summary>
    /// Executes the specified code.
    /// </summary>
    /// <param name="code">The code to execute.</param>
    void Code(string code);
}