namespace
#if SunamoShared
SunamoShared
#else
SunamoInterfaces
#endif
;
public interface IName
{
    string Name { get; set; }
}