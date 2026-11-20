namespace SunamoInterfaces.Interfaces;

// Must be in sunamo because is shared between MSSQL and SQL Server project.
/// <summary>
/// Represents the i database layer sql db type type.
/// </summary>
public interface IDatabaseLayer<SqlDbType> where SqlDbType : notnull
{
    /// <summary>
    /// Gets or sets the used tables.
    /// </summary>
    Dictionary<SqlDbType, string> UsedTables { get; set; }

    /// <summary>
    /// Gets or sets the hidden tables.
    /// </summary>
    Dictionary<SqlDbType, string> HiddenTables { get; set; }
}
