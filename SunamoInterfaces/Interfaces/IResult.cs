namespace SunamoInterfaces.Interfaces;

// Don't use this, use IControlWithResult instead. Only for closing operations.
public interface IResult
{
    // Don't use this, use IControlWithResult instead.
    event Action<object> Finished;
}
