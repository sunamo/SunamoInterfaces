using System.Data;

namespace
#if SunamoCollectionsValuesTableGrid
SunamoCollectionsValuesTableGrid
#else
SunamoInterfaces
#endif
;

public interface IValuesTableGrid<T>
{
    bool IsAllInColumn(int i, T value);
    bool IsAllInRow(int i, T value);
    DataTable SwitchRowsAndColumn();
    DataTable ToDataTable();
}