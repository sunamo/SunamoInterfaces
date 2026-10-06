namespace SunamoInterfaces.Interfaces;

// Must be in sunamo because is shared between MSSQL and SQL Server project.
public interface IDatabaseLayer<SqlDbType> where SqlDbType : notnull
{
    Dictionary<SqlDbType, string> UsedTables { get; set; }

    Dictionary<SqlDbType, string> HiddenTables { get; set; }
}
