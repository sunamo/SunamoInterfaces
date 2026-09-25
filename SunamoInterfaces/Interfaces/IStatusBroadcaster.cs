namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for broadcasting status messages.
/// </summary>
public interface IStatusBroadcaster
{
    /// <summary>
    /// Event raised when a new status is available.
    /// </summary>
    event Action<object, object[]> NewStatus;

    /// <summary>
    /// Raises a new status event with the specified status and parameters.
    /// </summary>
    /// <param name="status">The status message.</param>
    /// <param name="parameters">Additional parameters for the status.</param>
    void OnNewStatus(string status, params string[] parameters);
}