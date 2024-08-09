namespace SunamoInterfaces.Interfaces;

public interface IStatusBroadcasterAppend : IStatusBroadcaster
{
    event Action<object, object[]> NewStatusAppend;
    void OnNewStatusAppend(string s, params string[] p);
}