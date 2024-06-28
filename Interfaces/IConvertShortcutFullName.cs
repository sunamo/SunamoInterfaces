
namespace SunamoInterfaces;
public interface IConvertShortcutFullName
{
    string FromShortcut(string shortcut);
    string ToShortcut(string fullName);
}
