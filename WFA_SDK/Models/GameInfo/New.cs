using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.GameInfo
{
    public class New
    {
        public string id { get; set; }
        public string message { get; set; }
        public string link { get; set; }
        public string imageLink { get; set; }
        public bool priority { get; set; }
        public DateTime date { get; set; }
        public string eta { get; set; }
        public bool update { get; set; }
        public bool primeAccess { get; set; }
        public bool stream { get; set; }
        public Dictionary<string,string> translations { get; set; }
        public string asString { get; set; }

        public override bool Equals(object obj)
        {
            return obj is New @new &&
                   id == @new.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + EqualityComparer<string>.Default.GetHashCode(id);
        }
    }

    public class NewsTranslations
    {
        public string en { get; set; }
        public string fr { get; set; }
        public string it { get; set; }
        public string de { get; set; }
        public string es { get; set; }
        public string pt { get; set; }
        public string ru { get; set; }
        public string pl { get; set; }
        public string tr { get; set; }
        public string ja { get; set; }
        public string zh { get; set; }
        public string ko { get; set; }
        public string tc { get; set; }
    }

}
