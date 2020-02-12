using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Lib
{

    public class Archwing
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
        public List<PolarityEntity> polarities { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Archwing self &&
                   uniqueName == self.uniqueName;
        }

        public override int GetHashCode()
        {
            return 166490157 + EqualityComparer<string>.Default.GetHashCode(uniqueName);
        }
    }
    public class PolarityEntity
    {
        public int Id { get; set; }
        public string polarity { get; set; }
        public PolarityEntity()
        {

        }
        public PolarityEntity(string po)
        {
            polarity = po;
        }
    }
    public class TagEntity
    {
        public int Id { get; set; }
        public string tag { get; set; }
        public TagEntity()
        {

        }
        public TagEntity(string t)
        {
            tag = t;
        }
    }
    public class DamageTypeEntity
    {
        public int Id { get; set; }
        public string type { get; set; }
        public float value { get; set; }
        public DamageTypeEntity Clone()
        {
            return new DamageTypeEntity
            {
                Id = Id,
                type = type,
                value = value
            };
        }
    }

    public class Component
    {
        public int Id { get; set; }
        public string uniqueName { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float itemCount { get; set; }
        public string imageName { get; set; }
        public bool tradable { get; set; }
    }

    public class Drop
    {
        public int Id { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public float? chance { get; set; }
        public string rotation { get; set; }
    }
}
