using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoDomain.utils;

namespace AutoDomain.analyzer
{
    class BasicRegexAnalyzer : IAnalyse
    {

        //Support basic RegEx, e.g. [0-9]{3};  [G500]{3-4} => Google Top 500 frequency words;
        public List<string> analyse(string strPadding)
        {
            // Analyse [0-9]{3} => string
            // Support [begNumber - endNumber]{begTimes - endTimes}
            //  \[(\d+?)-(\d+?)\]({(\d+?)(-(\d*))?})?
            List<List<string>> arMatchResults = RegexHelper.Match(@"\[(\d+?)-(\d+?)\]({(\d+?)(-(\d*))?})?", strPadding);
            List<string> preMatchPadding = new List<string>();

            foreach (List<string> arList in arMatchResults)
            {
                int iBeg = Int32.Parse(arList[1]);
                int iEnd = Int32.Parse(arList[2]);

                int iNumFrom = arList[4] == "" ? 1 : Int32.Parse(arList[4]);
                int iNumTo = arList[6] == "" ? iNumFrom + 1 : Int32.Parse(arList[6]);

                for (int i = iBeg; i < iEnd; i++)
                {
                    string strReplace = i.ToString();

                    for (int iNum = iNumFrom; iNum < iNumTo; iNum++)
                    {
                        preMatchPadding.Add(strPadding.Replace(arList[0], strReplace));
                        strReplace += strReplace;
                    }
                }

            }

            //Rerplace Goolge Top N words

            return new List<string>();
        }
    }
}
