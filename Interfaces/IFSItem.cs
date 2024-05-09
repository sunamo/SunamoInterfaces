namespace
#if SunamoShared
SunamoShared
#else
SunamoInterfacesInterfaces
#endif
;

public interface IFSItem : IName, IPath, IIDParent
{
    long Length { get; set; }
}
