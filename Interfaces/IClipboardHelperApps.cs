namespace
#if SunamoClipboard
SunamoClipboard
#elif SunamoCl
    SunamoCl
#else
SunamoInterfaces
#endif
;



public interface IClipboardHelperApps : IClipboardHelperBase<string, List<string>, bool>
{
}
