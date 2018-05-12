using AutoDomain.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDomain.analyzer
{
    class GoogleTopWordsAnalyzer : IAnalyse
    {
        private List<string> arGoogleTopWords;

        public List<string> analyse(List<string> arPadding)
        {

            List<string> arProcessResult = new List<string>();

            foreach (string strPadding in arPadding)
            {

                //Replace Google Top N words
                //[G500]{3-4} Google Top 500, Length from 3 to 4
                // \[G(\d+?)\]({(\d+)(-(\d+))?})?
                List<List<string>> arMatchResults = RegexHelper.Match(@"\[G(\d+?)\]({(\d+)(-(\d+))?})?", strPadding);

                foreach (List<string> arList in arMatchResults)
                {

                    int iTop, iBeg, iEnd;

                    try
                    {
                        iTop = Int32.Parse(arList[1]);
                    }
                    catch
                    {
                        throw new AnalyseException("in [Gn], n must be a number;");
                    }

                    if (iTop <= 0 || iTop > 10000)
                    {
                        throw new AnalyseException("in [Gn], n must between 1 to 10000;");
                    }

                    try
                    {
                        iBeg = Int32.Parse(arList[3]);
                        iEnd = arList[5] == "" ? iBeg : Int32.Parse(arList[5]);
                    }
                    catch
                    {
                        throw new AnalyseException("in {a-b}, both a and b must be a number; if in {a}, a must be a number;");
                    }

                    if (iEnd < iBeg)
                    {
                        throw new AnalyseException("in {a-b}, b must equal or above a;");
                    }




                }

            }

            return arProcessResult;

        }

        public void init()
        {
            arGoogleTopWords = new List<string>();


        }
    }
}
