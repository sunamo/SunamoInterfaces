namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i searchable type.
/// </summary>
public interface ISearchable
{
    /// <summary>
    /// Contains data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The contains data result.</returns>
    bool ContainsData(object data);
}
