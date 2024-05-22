namespace SunamoInterfaces;


internal class MSSloupecDBArgs
{
    internal string nazev;
    internal bool primaryKey;
    internal string referencesTable;
    internal string referencesColumn;
    internal bool mustBeUnique;
    internal bool canBeNull;
    internal Signed signed;
    internal bool identityIncrementBy1;
}