using System;
using System.Collections.Generic;
using System.Text;

namespace WarframeAlertingPrime.SDK.Models.Others
{
    public class SearchRivenOrderOption:LastestRivenOrdersOption
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
        /// Is veiled riven mod? Default is <c>False</c>
        /// </summary>
        public bool IsVeiled { get; set; }
        public SearchRivenOrderOption():base()
        {
            IsVeiled = false;
        }
    }
}
