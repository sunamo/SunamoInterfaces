namespace SunamoInterfaces.Interfaces;

public interface IValuesTableGrid<T>
{
    bool IsAllInColumn(int columnIndex, T value);

    bool IsAllInRow(int rowIndex, T value);

    DataTable SwitchRowsAndColumn();

    DataTable ToDataTable();
}
