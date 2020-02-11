using System;
using System.Collections.Generic;
using System.Text;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class ConclaveChallenge
    {
        public string id { get; set; }
        public string description { get; set; }
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
        public int amount { get; set; }
        public string mode { get; set; }
        public string category { get; set; }
        public string eta { get; set; }
        public bool expired { get; set; }
        public bool daily { get; set; }
        public bool rootChallenge { get; set; }
        public string endString { get; set; }
        public string asString { get; set; }
    }

}
