using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGoogleTrends
{
    public class TrendsJsonResponse
    {

        public Default @default { get; set; }
        
        public class Default
        {
            public List<GeoMapDatum> geoMapData { get; set; }
            public List<TimelineDatum> timelineData { get; set; }
            public List<object> averages { get; set; }
        }


        


        public class GeoMapDatum
        {
            public string geoCode { get; set; }
            public string geoName { get; set; }
            public List<int> value { get; set; }
            public List<string> formattedValue { get; set; }
            public int maxValueIndex { get; set; }
            public List<bool> hasData { get; set; }
        }

        public class TimelineDatum
        {
            public string time { get; set; }
            public string formattedTime { get; set; }
            public string formattedAxisTime { get; set; }
            public List<int> value { get; set; }
            public List<bool> hasData { get; set; }
            public List<string> formattedValue { get; set; }
        }


    }
}
