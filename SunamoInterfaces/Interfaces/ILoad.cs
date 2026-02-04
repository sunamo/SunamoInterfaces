namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for loading data into an object.
/// </summary>
public interface ILoad
{
    /// <summary>
    /// Loads the specified data.
    /// </summary>
    /// <param name="data">The data to load.</param>
    void Load(object data);
}