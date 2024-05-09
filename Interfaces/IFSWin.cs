namespace
#if SunamoShared
SunamoShared
#elif SunamoWinStd
SunamoWinStd
#else
SunamoInterfacesInterfaces
#endif
;

public interface IFSWin
{
    void DeleteFileMaybeLocked(string s);
    void DeleteFileOrFolderMaybeLocked(string p);
}
