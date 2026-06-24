namespace SunamoInterfaces.Interfaces;

public interface IAsync
{
    T GetResult<T>(Task<T> task);
}
