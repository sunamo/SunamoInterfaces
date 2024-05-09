namespace
#if SunamoClipboard
SunamoClipboard
#else SunamoInterfacesInterfaces
SunamoInterfacesInterfaces
#endif
;



public interface IClipboardHelperApps : IClipboardHelperBase<string, List<string>, bool>
{
}
