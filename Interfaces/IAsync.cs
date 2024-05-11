namespace SunamoInterfaces;

public interface IAsync
{
    T GetResult<T>(Task<T> t);
}
