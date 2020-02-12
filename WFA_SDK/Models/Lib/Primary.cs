using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;


namespace WarframeAlertingPrime.SDK.Models.Lib
{

    public class Primary
    {
        
        public int Id { get; set; }
        public string name { get; set; }
        public string uniqueName { get; set; }
        public float secondsPerShot { get; set; }
        public float magazineSize { get; set; }
        public float reloadTime { get; set; }
        public float totalDamage { get; set; }
        public float damagePerSecond { get; set; }
        public string trigger { get; set; }
        public string description { get; set; }
        public float accuracy { get; set; }
        public float criticalChance { get; set; }
        public float criticalMultiplier { get; set; }
        public float procChance { get; set; }
        public float fireRate { get; set; }
        public float chargeAttack { get; set; }
        public float spinAttack { get; set; }
        public float leapAttack { get; set; }
        public float wallAttack { get; set; }
        public float slot { get; set; }
        public string noise { get; set; }
        public bool sentinel { get; set; }
        public float masteryReq { get; set; }
        public float omegaAttenuation { get; set; }
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
        public float ammo { get; set; }
        public string damage { get; set; }
        public List<DamageTypeEntity> damageTypes { get; set; }
        public string flight { get; set; }
        public List<PolarityEntity> polarities { get; set; }
        public string projectile { get; set; }
        public List<TagEntity> tags { get; set; }
        public string wikiaThumbnail { get; set; }
        public string wikiaUrl { get; set; }
        public float disposition { get; set; }
        public string exilus { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Primary primary &&
                   uniqueName == primary.uniqueName;
        }

        public override int GetHashCode()
        {
            return 166490157 + EqualityComparer<string>.Default.GetHashCode(uniqueName);
        }
    }
    public class Primary_Temp : Primary
    {
        public new List<string> polarities { get; set; }
        public new List<string> tags { get; set; }
        public new Dictionary<string, float> damageTypes { get; set; }
        public Primary Restore()
        {
            var temp_polarity = new List<PolarityEntity>();
            var temp_tag = new List<TagEntity>();
            var temp_damage = new List<DamageTypeEntity>();
            if (polarities != null)
            {
                foreach (var item in polarities)
                {
                    temp_polarity.Add(new PolarityEntity(item));
                }
            }
            if (tags != null)
            {
                foreach (var item in tags)
                {
                    temp_tag.Add(new TagEntity(item));
                }
            }
            if (damageTypes != null)
            {
                foreach (var item in damageTypes)
                {
                    temp_damage.Add(new DamageTypeEntity { type = item.Key, value = item.Value });
                }
            }
            var result = this as Primary;
            result.polarities = temp_polarity;
            result.tags = temp_tag;
            return result;
        }
    }
}
