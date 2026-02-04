namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for result handling.
/// Note: Don't use this, use IControlWithResult instead.
/// Only for closing operations.
/// </summary>
public interface IResult
{
    /// <summary>
    /// Event raised when operation is finished.
    /// Note: Don't use this, use IControlWithResult instead.
    /// </summary>
    event Action<object> Finished;
}