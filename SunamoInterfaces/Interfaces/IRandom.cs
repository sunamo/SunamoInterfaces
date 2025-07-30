namespace SunamoInterfaces.Interfaces;

public interface IRandom<T>
{
    int LenghtOfPpk { get; }
    T GetRandom();
}