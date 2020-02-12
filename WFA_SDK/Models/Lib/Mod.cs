using System;
using System.Collections.Generic;

using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Lib
{
    public class Mod
    {
        
        public int Id { get; set; }
        public string uniqueName { get; set; }
        public string name { get; set; }
        public string polarity { get; set; }
        public string rarity { get; set; }
        public float baseDrain { get; set; }
        public float fusionLimit { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string imageName { get; set; }
        public string category { get; set; }
        public bool tradable { get; set; }
        public bool isAugment { get; set; }
        public List<Drop> drops { get; set; }
        public List<Patchlog> patchlogs { get; set; }
        public List<ModEffect> effects { get; set; }
        public bool isExilus { get; set; }
        public List<ComboEffect> comboEffects { get; set; }
        public bool isCombo { get; set; }
        public bool isConclave { get; set; }
        public bool isFlaw { get; set; }
        public string series { get; set; }
        public Mod()
        {
            effects = new List<ModEffect>();
        }
        public override bool Equals(object obj)
        {
            return obj is Mod mod &&
                   uniqueName == mod.uniqueName;
        }

        public override int GetHashCode()
        {
            return 166490157 + EqualityComparer<string>.Default.GetHashCode(uniqueName);
        }
        public string GetDescription(int rank)
        {
            string des = Regex.Replace(description, "<.*?>", "");
            des = des.Replace(",", "\n");
            if (effects != null && effects.Count > 0)
            {

                for (int i = 0; i < effects.Count; i++)
                {
                    var item = effects[i];
                    if (item.ranks != null)
                    {
                        double v = item.ranks.Where(p => p.rank == rank).FirstOrDefault().value;
                        string rep = item.displayType == DisplayType.Percentage ? v + "%" : v.ToString();
                        if (v > 0 && item.displayType == DisplayType.Percentage)
                            rep = "+" + rep;
                        des = des.Replace($"{{{{{i}}}}}", rep);
                    }
                }
            }
            return des;
        }
    }
    public class ModEffect
    {
        public int Id { get; set; }
        public string type { get; set; }
        public List<ModEffectRank> ranks { get; set; }
        public DisplayType displayType { get; set; }
    }
    public class ModEffectRank
    {
        public int Id { get; set; }
        public int rank { get; set; }
        public float value { get; set; }
        public ModEffectRank Copy()
        {
            return new ModEffectRank
            {
                Id = Id,
                rank = rank,
                value = value
            };
        }
    }
    public class ComboEffect
    {
        public int Id { get; set; }
        public int many { get; set; }
        public int value { get; set; }
        public string type { get; set; }
        public DisplayType displayType { get; set; }
    }
    public enum DisplayType
    {
        Percentage,
        Number
    }
}
