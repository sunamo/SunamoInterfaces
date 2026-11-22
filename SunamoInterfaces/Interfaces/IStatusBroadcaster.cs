namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i status broadcaster type.
/// </summary>
public interface IStatusBroadcaster
{
    /// <summary>
    /// The new status.
    /// </summary>
    event Action<object, object[]> NewStatus;

    /// <summary>
    /// On new status.
    /// </summary>
    /// <param name="status">The status.</param>
    /// <param name="parameters">The parameters.</param>
    /// <returns>The on new status result.</returns>
    void OnNewStatus(string status, params string[] parameters);
}
