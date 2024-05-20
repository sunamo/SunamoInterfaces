using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace
#if SunamoDevCode
SunamoDevCode
#elif SunamoGitBashBuilder
SunamoGitBashBuilder
#elif SunamoInterfaces
SunamoInterfaces
#else
SunamoInterfaces
#endif
;
public interface ITypedLoggerBase
{
}