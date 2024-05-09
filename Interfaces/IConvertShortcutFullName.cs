namespace
#if SunamoConverters
SunamoConverters
#else SunamoInterfacesInterfaces
SunamoInterfacesInterfaces
#endif
;

public interface IConvertShortcutFullName
{
    string FromShortcut(string shortcut);
    string ToShortcut(string fullName);
}
