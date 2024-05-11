namespace
#if SunamoCl
SunamoCl
#elif SunamoClipboard
SunamoClipboard
#elif SunamoLogger
SunamoLogger
#elif SunamoShared
SunamoShared
#elif SunamoWinStd
SunamoWinStd
#else
SunamoInterfaces
#endif
;

/// <summary>
///     Must be in sunamo, is used in win and apps
/// </summary>
public interface IClipboardHelper : IClipboardHelperBase<string, List<string>, bool>
{
}