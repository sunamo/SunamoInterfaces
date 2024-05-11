namespace SunamoInterfaces;

public interface IRandom<T>
{
    T GetRandom();
    int LenghtOfPpk { get; }
}
