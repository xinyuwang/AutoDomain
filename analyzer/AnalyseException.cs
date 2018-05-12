using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDomain.analyzer
{
    class AnalyseException : Exception
    {

        const string strErrMessage = "Analyse error, unsuitable padding string.";

        public AnalyseException() : base(strErrMessage) { }

        public AnalyseException(string message) : base(message) { }

        public AnalyseException(string message, int lines) : base(String.Format("{0] - ErrLine : {1}", message, lines)) { }

    }
}
