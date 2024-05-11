namespace
#if SunamoClipboard
SunamoClipboard
#else
SunamoInterfaces
#endif
;



public interface IClipboardHelperApps : IClipboardHelperBase<string, List<string>, bool>
{
}
