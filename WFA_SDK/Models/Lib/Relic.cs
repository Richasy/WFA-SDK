using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Lib
{
    // WFCD warframe-items
    //WFCD drop-data
    public class Relic
    {
        
        public int Id { get; set; }
        public string uniqueName { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string imageName { get; set; }
        public string category { get; set; }
        public bool tradable { get; set; }
        public string tier { get; set; }
        public string relicName { get; set; }
        public string state { get; set; }
        public List<Reward> rewards { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Relic relic &&
                   uniqueName == relic.uniqueName;
        }

        public override int GetHashCode()
        {
            return 166490157 + EqualityComparer<string>.Default.GetHashCode(uniqueName);
        }
    }

    public class Reward
    {
        public int Id { get; set; }
        public string itemName { get; set; }
        public string rarity { get; set; }
        public float chance { get; set; }
    }

    public class Web_Relic
    {
        public string tier { get; set; }
        public string relicName { get; set; }
        public string state { get; set; }
        public Web_Reward[] rewards { get; set; }
        public string _id { get; set; }
    }

    public class Web_Reward:Reward
    {
        public string _id { get; set; }
    }

}
