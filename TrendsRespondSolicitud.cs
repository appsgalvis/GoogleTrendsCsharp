using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGoogleTrends
{
    internal class TrendsRespondSolicitud
    {

        public List<Widget> widgets { get; set; }
        public List<Keyword> keywords { get; set; }
        public List<string> timeRanges { get; set; }
        public List<object> examples { get; set; }
        public string shareText { get; set; }
        public bool shouldShowMultiHeatMapMessage { get; set; }

        public class Bullet
        {
            public string text { get; set; }
        }

        public class ComparisonItem
        {
            public Geo geo { get; set; }
            public ComplexKeywordsRestriction complexKeywordsRestriction { get; set; }
            public string time { get; set; }

            public string keyword { get; set; }
   

        }

        public class ComplexKeywordsRestriction
        {
            public List<Keyword> keyword { get; set; }
        }

        public class Geo
        {
            public string country { get; set; }
        }

        public class HelpDialog
        {
            public string title { get; set; }
            public string content { get; set; }
            public string url { get; set; }
        }

        public class Keyword
        {
            public string type { get; set; }
            public string value { get; set; }
        }

        public class Keyword3
        {
            public string keyword { get; set; }
            public string name { get; set; }
            public string type { get; set; }
        }

        public class Request
        {
            public string time { get; set; }
            public string resolution { get; set; }
            public string locale { get; set; }
            public List<ComparisonItem> comparisonItem { get; set; }
            public RequestOptions requestOptions { get; set; }
            public UserConfig userConfig { get; set; }
            public Geo geo { get; set; }
            public Restriction restriction { get; set; }
            public string keywordType { get; set; }
            public List<string> metric { get; set; }
            public TrendinessSettings trendinessSettings { get; set; }
            public string language { get; set; }
            public string userCountryCode { get; set; }
        }

        public class RequestOptions
        {
            public string property { get; set; }
            public string backend { get; set; }
            public int category { get; set; }
        }

        public class Restriction
        {
            public Geo geo { get; set; }
            public string time { get; set; }
            public string originalTimeRangeForExploreUrl { get; set; }
            public ComplexKeywordsRestriction complexKeywordsRestriction { get; set; }
        }

      
           
        

        public class TrendinessSettings
        {
            public string compareTime { get; set; }
        }

        public class UserConfig
        {
            public string userType { get; set; }
        }

        public class Widget
        {
            public Request request { get; set; }
            public string lineAnnotationText { get; set; }
            public List<Bullet> bullets { get; set; }
            public bool showLegend { get; set; }
            public bool showAverages { get; set; }
            public HelpDialog helpDialog { get; set; }
            public string token { get; set; }
            public string id { get; set; }
            public string type { get; set; }
            public string title { get; set; }
            public string template { get; set; }
            public string embedTemplate { get; set; }
            public string version { get; set; }
            public bool isLong { get; set; }
            public bool isCurated { get; set; }
            public string geo { get; set; }
            public string resolution { get; set; }
            public string searchInterestLabel { get; set; }
            public string displayMode { get; set; }
            public string color { get; set; }
            public int? index { get; set; }
            public string bullet { get; set; }
            public string keywordName { get; set; }
        }



    }
}
