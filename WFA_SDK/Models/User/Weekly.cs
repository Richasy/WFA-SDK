using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.User
{
    public class Weekly
    {
        public int Id { get; set; }
        public string itemType { get; set; }
        public string compatibility { get; set; }
        public bool rerolled { get; set; }
        public double avg { get; set; }
        public double stddev { get; set; }
        public double min { get; set; }
        public double max { get; set; }
        public double pop { get; set; }
        public string platform { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Weekly weekly &&
                   itemType == weekly.itemType &&
                   compatibility == weekly.compatibility &&
                   rerolled == weekly.rerolled &&
                   platform == weekly.platform;
        }

        public override int GetHashCode()
        {
            var hashCode = 1521328845;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(itemType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(compatibility);
            hashCode = hashCode * -1521134295 + rerolled.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(platform);
            return hashCode;
        }
    }
}
