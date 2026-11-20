namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i initialize after loaded type.
/// </summary>
public interface IInitializeAfterLoaded
{
    /// <summary>
    /// Set init after loaded.
    /// </summary>
    /// <param name="initAfterLoaded">The init after loaded.</param>
    void SetInitAfterLoaded(Action initAfterLoaded);
}
