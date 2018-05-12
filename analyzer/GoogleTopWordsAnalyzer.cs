using AutoDomain.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoDomain.analyzer
{
    class GoogleTopWordsAnalyzer : IAnalyse
    {
        private string[] arGoogleTopWords;

        public List<string> analyse(List<string> arPadding)
        {

            List<string> arProcessResult = new List<string>();

            foreach (string strPadding in arPadding)
            {

                List<string> arProcessPerPadding = new List<string> { strPadding };

                //Replace Google Top N words
                //[G500]{3-4} Google Top 500, Length from 3 to 4
                // \[G(\d+?)\]({(\d+)(-(\d+))?})?
                //Only 9897 Number
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

                    if (iTop <= 0 || iTop > 9897)
                    {
                        throw new AnalyseException("in [Gn], n must between 1 to 9897;");
                    }

                    try
                    {
                        iBeg = arList[3] == "" ? -1 : Int32.Parse(arList[3]);
                        iEnd = arList[5] == "" ? 9999 : Int32.Parse(arList[5]);
                    }
                    catch
                    {
                        throw new AnalyseException("in {a-b}, both a and b must be a number; if in {a}, a must be a number;");
                    }

                    if (iEnd < iBeg)
                    {
                        throw new AnalyseException("in {a-b}, b must equal or above a;");
                    }

                    List<string> arTempResult = new List<string>();

                    //TOP iTop
                    for (int i = 0; i < iTop; i++)
                    {
                        //check length between iBeg to iEnd
                        if (arGoogleTopWords[i].Length >= iBeg && arGoogleTopWords[i].Length <= iEnd)
                        {

                            foreach (string padding in arProcessPerPadding)
                            {
                                arTempResult.Add(padding.Replace(arList[0], arGoogleTopWords[i]));
                            }

                        }
                    }

                    arProcessPerPadding = arTempResult;

                }

                arProcessResult.AddRange(arProcessPerPadding);

            }

            return arProcessResult;

        }

        public void init()
        {
            arGoogleTopWords = File.ReadAllLines(@"resource\google-10000-english-no-swears.txt");
        }
    }
}
