using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Net;

namespace AutoDomain.utils
{
    class HttpHelper
    {
        public static string Get(string Url)
        {

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Timeout = 30 * 1000;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36";
            request.ContentType = "text/html; charset=utf-8";

            request.CookieContainer = new CookieContainer();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string strHtml = streamReader.ReadToEnd();
            streamReader.Close();
            return strHtml;
        }

    }
}
