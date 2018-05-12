using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDomain.analyzer
{
    interface IAnalyse
    {

        List<string> analyse(List<string> arPadding);

        void init();

    }
}
