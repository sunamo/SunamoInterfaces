namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i values table grid t type.
/// </summary>
public interface IValuesTableGrid<T>
{
    /// <summary>
    /// Is all in column.
    /// </summary>
    /// <param name="columnIndex">The column index.</param>
    /// <param name="value">The value.</param>
    /// <returns>The is all in column result.</returns>
    bool IsAllInColumn(int columnIndex, T value);

    /// <summary>
    /// Is all in row.
    /// </summary>
    /// <param name="rowIndex">The row index.</param>
    /// <param name="value">The value.</param>
    /// <returns>The is all in row result.</returns>
    bool IsAllInRow(int rowIndex, T value);

    /// <summary>
    /// Switch rows and column.
    /// </summary>
    /// <returns>The switch rows and column result.</returns>
    DataTable SwitchRowsAndColumn();

    /// <summary>
    /// To data table.
    /// </summary>
    /// <returns>The to data table result.</returns>
    DataTable ToDataTable();
}
