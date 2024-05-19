namespace
#if SunamoCollectionWithoutDuplicates
SunamoCollectionWithoutDuplicates
#elif SunamoDevCode
SunamoDevCode
#else
SunamoInterfaces
#endif
;
public interface IDumpAsString
{
    string DumpAsString(string operation, /*DumpAsStringHeaderArgs*/ Object dumpAsStringHeaderArgs);
}