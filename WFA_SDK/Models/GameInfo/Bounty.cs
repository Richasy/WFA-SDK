using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class Bounty
    {
        public int minLevel { get; set; }
        public int maxLevel { get; set; }
        public string sign { get; set; }
        public int order { get; set; }
        public string name { get; set; }
        public BountyReward[] rewards { get; set; }
    }

    public class BountyReward
    {
        public string itemName { get; set; }
        public string rarity { get; set; }
        public float chance { get; set; }
    }

}
