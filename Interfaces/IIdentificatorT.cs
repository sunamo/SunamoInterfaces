using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoInterfaces.Interfaces;
public interface IIdentificator<T>
{
    T Id { get; set; }
    bool IsChecked { get; set; }
    bool IsSelected { get; set; }


}
