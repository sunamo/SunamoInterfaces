namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for objects that hold an exception.
/// </summary>
public interface IException
{
    /// <summary>
    /// Gets or sets the exception.
    /// </summary>
    Exception Exception { get; set; }
}