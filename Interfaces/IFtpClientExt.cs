namespace
#if SunamoFtp
SunamoFtp
#else
SunamoInterfaces
#endif
;

public interface IFtpClientExt
{
    bool IsInFormatOfAlbum(string folderName);
    string SlashWwwSlash { get; }
    string WwwSlash { get; }
    string Www { get; }
}
