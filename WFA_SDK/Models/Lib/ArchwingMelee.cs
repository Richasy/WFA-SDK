using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_Lib.Models.Others;

namespace WarframeAlertingPrime.SDK.Models.Lib
{
    public class ArchwingMelee:IMelee
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
        public float channelingDrain { get; set; }
        public float channelingDamageMultiplier { get; set; }
        public float buildPrice { get; set; }
        public float buildTime { get; set; }
        public float skipBuildTimePrice { get; set; }
        public float buildQuantity { get; set; }
        public bool consumeOnBuild { get; set; }
        public List<Component> components { get; set; }
        public string imageName { get; set; }
        public string category { get; set; }
        public bool tradable { get; set; }
        public List<Patchlog> patchlogs { get; set; }
        public float channeling { get; set; }
        public string damage { get; set; }
        public List<DamageTypeEntity> damageTypes { get; set; }
        public List<PolarityEntity> polarities { get; set; }
        public List<TagEntity> tags { get; set; }
        public string wikiaThumbnail { get; set; }
        public string wikiaUrl { get; set; }
        public float disposition { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ArchwingMelee melee &&
                   uniqueName == melee.uniqueName;
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(uniqueName);
        }
    }
}
