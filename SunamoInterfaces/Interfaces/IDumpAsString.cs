namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for dumping objects as string representation.
/// </summary>
public interface IDumpAsString
{
    /// <summary>
    /// Dumps the object as a string with the specified operation and header arguments.
    /// </summary>
    /// <param name="operation">The operation being performed.</param>
    /// <param name="dumpAsStringHeaderArgs">The dump header arguments.</param>
    /// <returns>String representation of the object.</returns>
    string DumpAsString(string operation, /*DumpAsStringHeaderArgs*/ object dumpAsStringHeaderArgs);
}