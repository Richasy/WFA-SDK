using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class Event
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
        public DateTime expiry { get; set; }
        public bool active { get; set; }
        public double? maximumScore { get; set; }
        public double? currentScore { get; set; }
        public double? smallInterval { get; set; }
        public double? largeInterval { get; set; }
        public string description { get; set; }
        public string tooltip { get; set; }
        public string victimNode { get; set; }
        public bool expired { get; set; }
        public float? health { get; set; }
        public string affiliatedWith { get; set; }
        public string asString { get; set; }
        public string factory { get; set; }
        public string node { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Event rootobject &&
                   id == rootobject.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + EqualityComparer<string>.Default.GetHashCode(id);
        }
    }

}
