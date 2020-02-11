using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class Stalker
    {
        public string id { get; set; }
        public string agentType { get; set; }
        public string locationTag { get; set; }
        public int rank { get; set; }
        public float healthPercent { get; set; }
        public int fleeDamage { get; set; }
        public DateTime lastDiscoveredTime { get; set; }
        public string lastDiscoveredAt { get; set; }
        public bool isDiscovered { get; set; }
        public bool isUsingTicketing { get; set; }
        public string pid { get; set; }
    }

}
