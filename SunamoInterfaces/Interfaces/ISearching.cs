namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Non-generic searching interface that returns string.
/// If there are multiple classes with the same search interface in a class, this is used.
/// </summary>
public interface ISearching : ISearchingT<string>
{
}