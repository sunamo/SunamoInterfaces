namespace SunamoInterfaces.Interfaces;

// Don't use this, use IControlWithResult instead. Only for closing operations.
/// <summary>
/// Represents the i result type.
/// </summary>
public interface IResult
{
    // Don't use this, use IControlWithResult instead.
    /// <summary>
    /// The finished.
    /// </summary>
    event Action<object> Finished;
}
