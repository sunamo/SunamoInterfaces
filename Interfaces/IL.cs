namespace
#if SunamoShared
SunamoShared
#elif SunamoEnums
SunamoEnums
#else
SunamoInterfaces
#endif
;
public interface IL<T> : IList<T>
{
}