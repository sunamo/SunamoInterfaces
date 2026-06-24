namespace SunamoInterfaces.Interfaces;

public interface IFSWin
{
    void DeleteFileMaybeLocked(string filePath);

    void DeleteFileOrFolderMaybeLocked(string path);
}
