namespace SunamoInterfaces.Interfaces;

public interface IRegistry
{
    void SetValue(object value, string path);
    object GetValue(string path);
}
