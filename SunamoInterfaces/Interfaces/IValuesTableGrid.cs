namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for table grid operations with typed values.
/// </summary>
/// <typeparam name="T">The type of values in the grid.</typeparam>
public interface IValuesTableGrid<T>
{
    /// <summary>
    /// Determines whether all cells in the specified column contain the specified value.
    /// </summary>
    /// <param name="columnIndex">The column index to check.</param>
    /// <param name="value">The value to check for.</param>
    /// <returns>True if all cells in the column contain the value; otherwise, false.</returns>
    bool IsAllInColumn(int columnIndex, T value);

    /// <summary>
    /// Determines whether all cells in the specified row contain the specified value.
    /// </summary>
    /// <param name="rowIndex">The row index to check.</param>
    /// <param name="value">The value to check for.</param>
    /// <returns>True if all cells in the row contain the value; otherwise, false.</returns>
    bool IsAllInRow(int rowIndex, T value);

    /// <summary>
    /// Switches rows and columns (transposes the table).
    /// </summary>
    /// <returns>The transposed DataTable.</returns>
    DataTable SwitchRowsAndColumn();

    /// <summary>
    /// Converts the grid to a DataTable.
    /// </summary>
    /// <returns>The DataTable representation of the grid.</returns>
    DataTable ToDataTable();
}