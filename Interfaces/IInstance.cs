namespace SunamoInterfaces;

public interface IInstance<T>
{
    T CreateInstance(object o);
}
