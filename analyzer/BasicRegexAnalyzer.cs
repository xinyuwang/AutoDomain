using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoDomain.utils;
using System.IO;

namespace AutoDomain.analyzer
{
    class BasicRegexAnalyzer : IAnalyse
    {

        //Support basic RegEx, e.g. [0-9]{3};  [G500]{3-4} => Google Top 500 frequency words;
        public List<string> analyse(List<string> arPadding)
        {

            List<string> arProcessResult = new List<string>();

            foreach (string strPadding in arPadding)
            {
                List<string> arProcessPerPadding = new List<string> { strPadding };

                // Analyse [0-9]{3} => string
                // Support [begNumber - endNumber]{begTimes - endTimes}
                //  \[(\d+?)-(\d+?)\]({(\d+?)(-(\d*))?})?
                List<List<string>> arMatchResults = RegexHelper.Match(@"\[(\d+?)-(\d+?)\]({(\d+?)(-(\d*))?})?", strPadding);

                foreach (List<string> arList in arMatchResults)
                {

                    int iBeg, iEnd, iNumFrom, iNumTo;

                    try
                    {

                        iBeg = Int32.Parse(arList[1]);
                        iEnd = Int32.Parse(arList[2]);

                    }
                    catch
                    {
                        throw new AnalyseException("in [a-b], both a and b must be a number;");
                    }


                    if (iEnd <= iBeg)
                    {
                        throw new AnalyseException("in [a-b], b must above a; if a equal to b, don't use [];");
                    }


                    try
                    {
                        iNumFrom = arList[4] == "" ? 1 : Int32.Parse(arList[4]);
                        iNumTo = arList[6] == "" ? iNumFrom : Int32.Parse(arList[6]);
                    }
                    catch
                    {
                        throw new AnalyseException("in {a-b}, both a and b must be a number;");
                    }


                    if (iNumTo < iNumFrom)
                    {
                        throw new AnalyseException("in {a-b}, b must above a; if a equal to b, please use {a} instead;");
                    }

                    List<string> arTempResult = new List<string>();

                    //From 1 times
                    List<string> arPrefix = new List<string>() { "" };
                    for (int iNum = 1; iNum <= iNumTo; iNum++)
                    {
                        List<string> arTempPrefix = new List<string>();
                        foreach (string strPrefix in arPrefix)
                        {
                            for (int i = iBeg; i <= iEnd; i++)
                            {
                                string prefix = strPrefix + i.ToString();
                                arTempPrefix.Add(prefix);

                                //check times
                                if (iNum >= iNumFrom)
                                {
                                    foreach (string padding in arProcessPerPadding)
                                    {
                                        arTempResult.Add(padding.Replace(arList[0], prefix));
                                    }
                                }

                            }
                        }

                        arPrefix = arTempPrefix;

                    }

                    arProcessPerPadding = arTempResult;

                }

                arProcessResult.AddRange(arProcessPerPadding);

            }

            return arProcessResult;
        }

        public void init()
        {


        }


    }
}
