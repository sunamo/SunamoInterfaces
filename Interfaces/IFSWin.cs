
namespace SunamoInterfaces;
public interface IFSWin
{
    void DeleteFileMaybeLocked(string s);
    void DeleteFileOrFolderMaybeLocked(string p);
}
