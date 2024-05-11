namespace
#if SunamoConverters
SunamoConverters
#else
SunamoInterfaces
#endif
;

public interface IConvertShortcutFullName
{
    string FromShortcut(string shortcut);
    string ToShortcut(string fullName);
}
