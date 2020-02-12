using System;
using System.Collections.Generic;
using System.Text;

namespace WarframeAlertingPrime.SDK.Models.Others
{
    public class RivenAdvicePriceOption
    {
        /// <summary>
        /// Weapon name. eg. Tigris
        /// </summary>
        public string Weapon { get; set; }
        /// <summary>
        /// Weapon category. eg. Melee
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Is mod rerolled. default is <c>null</c>
        /// </summary>
        public bool? IsRerolled { get; set; }
        public RivenAdvicePriceOption()
        {
            Weapon = "";
            Category = "";
            IsRerolled = null;
        }
    }
}
