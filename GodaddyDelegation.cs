using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AutoDomain.utils;
using Newtonsoft.Json.Linq;

namespace AutoDomain
{
    class GodaddyDelegation
    {

        public static DomainInfo CheckDomain(string url)
        {

            string strJson = HttpHelper.Get(String.Format(@"https://find.godaddy.com/en/domainsapi/v1/search/exact?key=dpp_search&pc=&ptl=&q={0}", url));

            JObject jRoot = JObject.Parse(strJson);

            if (jRoot["ExactMatchDomain"].Value<Boolean>("IsAvailable") == false)
            {
                return null;
            }

            DomainInfo domainInfo = new DomainInfo();

            domainInfo.URL = url;

            double dListPrice = jRoot["Products"][0]["PriceInfo"].Value<Double>("ListPrice");
            domainInfo.Price = dListPrice;

            return domainInfo;
        }

    }
}
