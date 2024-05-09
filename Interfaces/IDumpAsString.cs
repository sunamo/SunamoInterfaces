namespace
#if SunamoCollectionWithoutDuplicates
SunamoCollectionWithoutDuplicates
#else SunamoInterfacesInterfaces
SunamoInterfacesInterfaces
#endif
;

public interface IDumpAsString
{
    string DumpAsString(string operation, /*DumpAsStringHeaderArgs*/ Object dumpAsStringHeaderArgs);
}
