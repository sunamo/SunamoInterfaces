namespace SunamoInterfaces._sunamo.SunamoArgs;

internal class MSColumnDBArgs
{
    internal bool CanBeNull { get; set; }
    internal bool IsIdentityIncrementBy1 { get; set; }
    internal bool MustBeUnique { get; set; }
    internal string? Name { get; set; }
    internal bool IsPrimaryKey { get; set; }
    internal string? ReferencesColumn { get; set; }
    internal string? ReferencesTable { get; set; }
    internal Signed Signed { get; set; }
}