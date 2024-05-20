namespace
#if SunamoShared
SunamoShared
#else
SunamoInterfaces
#endif
;
public interface IPath
{
    string Path { get; set; }
}