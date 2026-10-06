namespace SunamoInterfaces.Interfaces;

public interface IRandom<T>
{
    int LengthOfPasswordKey { get; }
    T GetRandom();
}
