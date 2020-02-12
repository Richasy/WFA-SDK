using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Lib
{

    public class Arcanes
    {
        
        public int Id { get; set; }
        public string uniqueName { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string imageName { get; set; }
        public string category { get; set; }
        public bool tradable { get; set; }
        public string rarity { get; set; }
        public List<Patchlog> patchlogs { get; set; }
        public List<ArcaneEffect> effects { get; set; }
        public string description { get; set; }
        public Arcanes()
        {
            patchlogs = new List<Patchlog>();
            effects = new List<ArcaneEffect>();
        }

        public override bool Equals(object obj)
        {
            return obj is Arcanes arcanes &&
                   uniqueName == arcanes.uniqueName;
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(uniqueName);
        }
    }

    public class ArcaneEffect
    {
        public int Id { get; set; }
        public int rank { get; set; }
        public string value { get; set; }
    }
}
