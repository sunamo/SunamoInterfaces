namespace
#if SunamoShared
SunamoShared
#else
SunamoInterfaces
#endif
;
public interface IUri
{
    string Uri { get; set; }
}