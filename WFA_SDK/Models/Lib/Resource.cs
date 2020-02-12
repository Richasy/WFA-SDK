using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Lib
{
    public class Resource
    {
        
        public int Id { get; set; }
        public string uniqueName { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float buildPrice { get; set; }
        public float buildTime { get; set; }
        public float skipBuildTimePrice { get; set; }
        public float buildQuantity { get; set; }
        public bool consumeOnBuild { get; set; }
        public List<Component> components { get; set; }
        public string type { get; set; }
        public string imageName { get; set; }
        public string category { get; set; }
        public bool tradable { get; set; }
        public List<Patchlog> patchlogs { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Resource resource &&
                   uniqueName == resource.uniqueName;
        }

        public override int GetHashCode()
        {
            return 166490157 + EqualityComparer<string>.Default.GetHashCode(uniqueName);
        }
    }

}
