namespace
#if SunamoCollectionWithoutDuplicates
SunamoCollectionWithoutDuplicates
#else
SunamoInterfaces
#endif
;

public interface IDumpAsString
{
    string DumpAsString(string operation, /*DumpAsStringHeaderArgs*/ Object dumpAsStringHeaderArgs);
}
