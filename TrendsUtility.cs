using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DemoGoogleTrends
{
    class TrendsUtility
    {
        
        public static readonly string T1_HORA = "now 1-H";
        public static readonly string T4_HORA = "now 4-H";
        public static readonly string T1_DIA  = "now 1-d";
        public static readonly string T7_DIA  = "now 7-d";
        public static readonly string T30_DIA = "today 1-m";
        

        

        public TrendsRespondSolicitud getTrendsRespondSolicitud(TrendsSolicitud solicitud) {
            Uri url = new Uri("https://trends.google.es/trends/api/explore?req=" + JsonConvert.SerializeObject(solicitud) + "&hl=es&tz=300");
           return JsonConvert.DeserializeObject<TrendsRespondSolicitud>(GetData(url, getCookie(url)));
        }

       




        public  CookieContainer getCookie(Uri url)
        {
            CookieContainer ResponseCookies = new CookieContainer();
            //  Console.WriteLine("SetCookie");
            RestClient client = new RestClient(url.OriginalString);
                client.CookieContainer = new CookieContainer();
                client.Timeout = 60000;
                client.FollowRedirects = true;
            RestRequest request = new RestRequest(Method.POST);
                request.AddHeader("Accept", "*/*");
                request.AddHeader("Host", url.Host);
                request.RequestFormat = DataFormat.Json;
            IRestResponse response = client.Execute(request);
                  
                ResponseCookies.Add(url, new Cookie(response.Cookies[0].Name, response.Cookies[0].Value));
           // Console.WriteLine(url.OriginalString);
           // Console.WriteLine("Cookie=" + cookie1.Name + "=" + cookie1.Value);
           // Console.WriteLine("-------------------------------------------------------------------------------------------------");
            return ResponseCookies;
        }





        public string GetData(Uri url, CookieContainer cookies)
        {
            //Console.WriteLine("GetData");
            //Console.WriteLine(url.OriginalString);
            //if (cookies != null) { Console.WriteLine("Cookie=" + cookies.GetCookies(url)[0].Name + "=" + cookies.GetCookies(url)[0].Value); }
            RestClient client = new RestClient(url.OriginalString);
                client.CookieContainer = cookies;
                client.Timeout = 60000;
                client.FollowRedirects = true;

            RestRequest request = new RestRequest(Method.GET);
                request.AddHeader("Accept", "*/*");
                request.AddHeader("Host", url.Host);
                request.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(request);
            string repuesta = response.Content.Normalize().Substring(5);
           // Console.WriteLine(repuesta);
           // Console.WriteLine("-------------------------------------------------------------------------------------------------");
            return repuesta;
        }
    }
}
