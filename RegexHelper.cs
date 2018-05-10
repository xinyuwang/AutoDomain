using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RuleAnalysis
{
    class RegexHelper
    {

        public static string MatchSingle(string sRegex, string sContent)
        {

            Regex reg = new Regex(sRegex);
            Match m = reg.Match(sContent);

            if (null != m)
            {
                return m.Groups[1].Value;
            }
            else
            {
                return "";
            }

        }

        public static int MatchCount(string sRegex, string sContent)
        {
            Regex reg = new Regex(sRegex);
            Match m = reg.Match(sContent);
            int iCnt = 0;
            if (null != m)
            {
                foreach (Group g in m.Groups)
                {
                    if (g.Success)
                    {
                        iCnt++;
                    }
                }
            }
            return iCnt;
        }


        public static List<string> MatchMulti(string sRegex, string sContent)
        {

            Regex reg = new Regex(sRegex);
            MatchCollection mc = reg.Matches(sContent);

            List<string> retList = new List<string>();

            foreach (Match m in mc)
            {
                retList.Add(m.Groups[1].Value);
            }

            return retList;

        }


    }
}
