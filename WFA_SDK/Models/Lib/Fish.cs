using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Lib
{
    public class Fish
    {
        
        public int Id { get; set; }
        public string uniqueName { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string imageName { get; set; }
        public string category { get; set; }
        public bool tradable { get; set; }
        public List<Patchlog> patchlogs { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Fish fish &&
                   uniqueName == fish.uniqueName;
        }

        public override int GetHashCode()
        {
            return 166490157 + EqualityComparer<string>.Default.GetHashCode(uniqueName);
        }
    }

}
