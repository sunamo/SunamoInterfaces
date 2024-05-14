namespace
#if SunamoShared
SunamoShared
#else
SunamoInterfaces
#endif
;

public interface IDW
{
    string SelectOfFolder(string rootFolder);
    string SelectOfFolder(Environment.SpecialFolder rootFolder);
}
