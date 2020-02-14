using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.WarframeMarket
{
    public class Item
    {
        public string[] tags { get; set; }
        public int ducats { get; set; }
        public LanguageName ko { get; set; }
        public string icon { get; set; }
        public LanguageName sv { get; set; }
        public LanguageName fr { get; set; }
        public LanguageName ru { get; set; }
        public string icon_format { get; set; }
        public int trading_tax { get; set; }
        public string thumb { get; set; }
        public LanguageName en { get; set; }
        public int mastery_level { get; set; }
        public string id { get; set; }
        public string url_name { get; set; }
        public LanguageName zh { get; set; }
        public LanguageName de { get; set; }
        public bool set_root { get; set; }
        public string sub_icon { get; set; }
        public string rarity { get; set; }
    }

    public class LanguageName
    {
        public string item_name { get; set; }
        public string description { get; set; }
        public string wiki_link { get; set; }
        public Drop[] drop { get; set; }
    }
    public class Drop
    {
        public string name { get; set; }
        public object link { get; set; }
    }

}
