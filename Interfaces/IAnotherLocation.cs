namespace SunamoInterfaces;

public interface IAnotherLocation<T, U>
{
    T Root { get; set; }
    U ReturnRightLocation(T id);
}
