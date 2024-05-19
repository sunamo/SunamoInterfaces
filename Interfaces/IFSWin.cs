namespace
#if SunamoShared
SunamoShared
#elif SunamoWinStd
SunamoWinStd
#else
SunamoInterfaces
#endif
;
public interface IFSWin
{
    void DeleteFileMaybeLocked(string s);
    void DeleteFileOrFolderMaybeLocked(string p);
}