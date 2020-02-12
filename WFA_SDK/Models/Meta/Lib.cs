using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Meta
{
    public class Lib
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string uniqueName { get; set; }
        public string thumb { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Lib lib &&
                   uniqueName == lib.uniqueName;
        }

        public override int GetHashCode()
        {
            return 166490157 + EqualityComparer<string>.Default.GetHashCode(uniqueName);
        }

        public Lib()
        {

        }
        public Lib(Lib lib)
        {
            Id = lib.Id;
            name = lib.name;
            type = lib.type;
            uniqueName = lib.uniqueName;
            thumb = lib.thumb;
        }
    }
}
