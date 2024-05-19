namespace
#if SunamoCollectionsGeneric
SunamoCollectionsGeneric
#else
SunamoInterfaces
#endif
;
public interface IIdentificator
{
    object Id { get; set; }
}