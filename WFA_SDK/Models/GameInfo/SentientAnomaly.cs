using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class SentientAnomaly
    {
        public SentientMission mission { get; set; }
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public bool active { get; set; }
        public string id { get; set; }

        public override bool Equals(object obj)
        {
            return obj is SentientAnomaly anomaly &&
                   id == anomaly.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + EqualityComparer<string>.Default.GetHashCode(id);
        }
    }

    public class SentientMission
    {
        public string node { get; set; }
        public string faction { get; set; }
        public string type { get; set; }
    }

}
