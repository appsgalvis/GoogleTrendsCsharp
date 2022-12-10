using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGoogleTrends
{
    internal class TrendsGetDataMapa
    {
        public Geo geo { get; set; }
        public List<ComparisonItem> comparisonItem { get; set; }
        public string resolution { get; set; }
        public string locale { get; set; }
        public RequestOptions requestOptions { get; set; }
        public UserConfig userConfig { get; set; }

        public string token { get; set; }


        public TrendsGetDataMapa(TrendsRespondSolicitud RespondSolicitud) {
            this.geo = new Geo();
            this.comparisonItem = new List<ComparisonItem>();
            ComparisonItem comparisonItem = new ComparisonItem();
            comparisonItem.time = RespondSolicitud.widgets[1].request.comparisonItem[0].time;
            comparisonItem.complexKeywordsRestriction = new ComplexKeywordsRestriction();
            comparisonItem.complexKeywordsRestriction.keyword = new List<Keyword>();
            Keyword keyword = new Keyword();
            keyword.value = RespondSolicitud.widgets[1].request.comparisonItem[0].complexKeywordsRestriction.keyword[0].value;
            keyword.type = RespondSolicitud.widgets[1].request.comparisonItem[0].complexKeywordsRestriction.keyword[0].type;
            comparisonItem.complexKeywordsRestriction.keyword.Add(keyword);
            this.comparisonItem.Add(comparisonItem);
            this.resolution = RespondSolicitud.widgets[1].request.resolution;
            this.locale = RespondSolicitud.widgets[1].request.locale;
            this.requestOptions = new RequestOptions();
            this.requestOptions.property = RespondSolicitud.widgets[1].request.requestOptions.property;
            this.requestOptions.backend = RespondSolicitud.widgets[1].request.requestOptions.backend;
            this.userConfig = new UserConfig();
            this.userConfig.userType = RespondSolicitud.widgets[1].request.userConfig.userType;
           this.token = RespondSolicitud.widgets[1].token;
        }



        public string getRawDataCSV()
        {
            Uri data = new Uri("https://trends.google.es/trends/api/widgetdata/multiline/csv?req=" + JsonConvert.SerializeObject(this) + "&token=" + this.token + "&tz=300");
            return new TrendsUtility().GetData(data, null);
        }


        public TrendsJsonResponse getTrendsJsonResponse()
        {
            Uri data = new Uri("https://trends.google.es/trends/api/widgetdata/comparedgeo/json?req=" + JsonConvert.SerializeObject(this) + "&token=" + this. token + "&tz=300");
            string resul = new TrendsUtility().GetData(data, null);
            return JsonConvert.DeserializeObject<TrendsJsonResponse>(resul);
        }



        public class ComparisonItem
        {
            public string time { get; set; }
            public ComplexKeywordsRestriction complexKeywordsRestriction { get; set; }
        }

        public class ComplexKeywordsRestriction
        {
            public List<Keyword> keyword { get; set; }
        }

        public class Geo
        {
        }

        public class Keyword
        {
            public string type { get; set; }
            public string value { get; set; }
        }

        public class RequestOptions
        {
            public string property { get; set; }
            public string backend { get; set; }
            public int category { get; set; }
        }

       

        public class UserConfig
        {
            public string userType { get; set; }
        }





    }
}
