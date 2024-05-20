namespace
#if SunamoShared
SunamoShared
#else
SunamoInterfaces
#endif
;
public interface IIDParent
{
    int IDParent { get; set; }
}