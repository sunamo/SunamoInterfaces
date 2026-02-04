namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for saving data.
/// </summary>
public interface ISave
{
    /// <summary>
    /// Saves the specified data.
    /// </summary>
    /// <param name="data">The data to save.</param>
    void Save(object data);
}