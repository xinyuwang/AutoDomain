using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AutoDomain.utils
{
    class RegexHelper
    {

        public static List<List<string>> Match(string sRegex, string sContent)
        {
            List<string> retList = new List<string>();
            Regex reg = new Regex(sRegex);
            MatchCollection mc = reg.Matches(sContent);

            List<List<string>> listResult = new List<List<string>>(); 

            foreach (Match m in mc)
            {
                List<string> result = new List<string>();
                for(int i = 0; i < m.Groups.Count; i++) 
                {
                    result.Add(m.Groups[i].Value);
                }
                listResult.Add(result);
            }

            return listResult;

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


    }
}
