using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGoogleTrends
{
    internal class TrendsSolicitud
    {




        public List<ComparisonItem> comparisonItem { get; set; }
        public int category { get; set; }
        public string property { get; set; }


        public TrendsSolicitud(string keyword,string geo, string time) {

            comparisonItem = new List<ComparisonItem>();
            comparisonItem.Add(new ComparisonItem(){keyword = keyword,geo = geo,time = time});

            category = 0;
            property = "";

        }

        public class ComparisonItem
        {
            public string keyword { get; set; }
            public string geo { get; set; }
            public string time { get; set; }
        }





        public class Geo
        {
            public string country { get; set; }
        }


    }
}
