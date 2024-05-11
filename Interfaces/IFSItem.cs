namespace
#if SunamoShared
SunamoShared
#else
SunamoInterfaces
#endif
;

public interface IFSItem : IName, IPath, IIDParent
{
    long Length { get; set; }
}
