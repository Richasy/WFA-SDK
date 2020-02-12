using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;


namespace WarframeAlertingPrime.SDK.Models.Lib
{

    public class Warframe
    {
        
        public int Id { get; set; }
        public string uniqueName { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float health { get; set; }
        public float shield { get; set; }
        public float armor { get; set; }
        public float stamina { get; set; }
        public float power { get; set; }
        public float masteryReq { get; set; }
        public float sprintSpeed { get; set; }
        public string passiveDescription { get; set; }
        public List<Ability> abilities { get; set; }
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
        public string aura { get; set; }
        public bool conclave { get; set; }
        public float color { get; set; }
        public string introduced { get; set; }
        public List<PolarityEntity> polarities { get; set; }
        public string sex { get; set; }
        public float sprint { get; set; }
        public string wikiaThumbnail { get; set; }
        public string wikiaUrl { get; set; }
        public string exilus { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Warframe warframe &&
                   uniqueName == warframe.uniqueName;
        }

        public override int GetHashCode()
        {
            return 166490157 + EqualityComparer<string>.Default.GetHashCode(uniqueName);
        }
    }
    
    public class Ability
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
