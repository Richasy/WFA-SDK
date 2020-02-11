using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class Invasion
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
        public string node { get; set; }
        public string desc { get; set; }
        public FactoryReward attackerReward { get; set; }
        public string attackingFaction { get; set; }
        public FactoryReward defenderReward { get; set; }
        public string defendingFaction { get; set; }
        public bool vsInfestation { get; set; }
        public int count { get; set; }
        public int requiredRuns { get; set; }
        public float completion { get; set; }
        public bool completed { get; set; }
        public string eta { get; set; }
        public string[] rewardTypes { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Invasion invasion &&
                   id == invasion.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + EqualityComparer<string>.Default.GetHashCode(id);
        }

    }

    public class FactoryReward
    {
        public object[] items { get; set; }
        public Counteditem[] countedItems { get; set; }
        public int credits { get; set; }
        public string asString { get; set; }
        public string itemString { get; set; }
        public string thumbnail { get; set; }
        public int color { get; set; }
    }

    public class Counteditem
    {
        public int count { get; set; }
        public string type { get; set; }
    }

}
