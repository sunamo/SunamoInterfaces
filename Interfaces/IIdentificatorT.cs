using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace
#if SunamoCollectionsGeneric
SunamoCollectionsGeneric
#elif SunamoInterfaces
SunamoInterfaces
#else
SunamoInterfaces.Interfaces
#endif
;
public interface IIdentificatorT<T>
{
    T Id { get; set; }
    bool IsChecked { get; set; }
    bool IsSelected { get; set; }
}