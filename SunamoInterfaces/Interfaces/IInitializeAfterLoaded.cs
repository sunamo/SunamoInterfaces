namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for setting initialization actions to run after loading is complete.
/// </summary>
public interface IInitializeAfterLoaded
{
    /// <summary>
    /// Sets the action to execute after loading is complete.
    /// </summary>
    /// <param name="initAfterLoaded">The action to execute after loading.</param>
    void SetInitAfterLoaded(Action initAfterLoaded);
}