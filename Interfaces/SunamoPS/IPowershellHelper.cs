namespace
#if SunamoPS
SunamoPS
#elif SunamoShared
SunamoShared
#else
SunamoInterfaces
#endif
;
public interface IPowershellHelper
{
#if ASYNC
    Task
#else
void
#endif
    CmdC(string v, Func<bool, ITextBuilder> ciTextBuilder);
#if ASYNC
    Task<string>
#else
string
#endif
    DetectLanguageForFileGithubLinguist(string windowsPath);
    List<string> ProcessNames();
}