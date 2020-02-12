using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WarframeAlertingPrime.SDK.Models.Enums;
using WarframeAlertingPrime.SDK.Models.Lib;
using WarframeAlertingPrime.SDK.Models.Others;
using WarframeAlertingPrime.SDK.Tools;

namespace WarframeAlertingPrime.SDK.Models.Core
{
    public partial class Client
    {
        private async Task<T> GetLibData<T>(string id, string type, LanguageType lan) where T : class
        {
            string route = Statics.LIB_QUERY_URL + $"?language={lan.ToString().ToLower()}&item={WebUtility.UrlEncode(id)}&category={type}";
            var data = await NetworkTools.GetEntityAsync<T>(route, Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Get Warframe data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<Warframe> GetWarframeDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<Warframe>(uniqueName, "Warframes", lan);
        }
        /// <summary>
        /// Get Arcane data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<Arcanes> GetArcaneDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<Arcanes>(uniqueName, "Arcanes", lan);
        }
        /// <summary>
        /// Get Archwing data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<Archwing> GetArchwingDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<Archwing>(uniqueName, "Archwing", lan);
        }
        /// <summary>
        /// Get Archwing gun data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<ArchwingGun> GetArchGunDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<ArchwingGun>(uniqueName, "Arch-Gun", lan);
        }
        /// <summary>
        /// Get Archwing data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<ArchwingMelee> GetArchMeleeDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<ArchwingMelee>(uniqueName, "Arch-Melee", lan);
        }
        /// <summary>
        /// Get Primary data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<Primary> GetPrimaryDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<Primary>(uniqueName, "Primary", lan);
        }
        /// <summary>
        /// Get Secondary data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<Secondary> GetSecondaryDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<Secondary>(uniqueName, "Secondary", lan);
        }
        /// <summary>
        /// Get Melee data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<Melee> GetMeleeDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<Melee>(uniqueName, "Melee", lan);
        }
        /// <summary>
        /// Get Mod data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<Mod> GetModDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<Mod>(uniqueName, "Mods", lan);
        }
        /// <summary>
        /// Get Relic data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<Relic> GetRelicDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<Relic>(uniqueName, "Relics", lan);
        }
        /// <summary>
        /// Get Fish data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<Fish> GetFishDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<Fish>(uniqueName, "Fish", lan);
        }
        /// <summary>
        /// Get Resource data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<Resource> GetResourceDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<Resource>(uniqueName, "Resources", lan);
        }
        /// <summary>
        /// Get Pet data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<Pet> GetPetDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<Pet>(uniqueName, "Pets", lan);
        }
        /// <summary>
        /// Get Sentinel data from lib
        /// </summary>
        /// <param name="uniqueName">Item id</param>
        /// <param name="lan">Language. The default is Zh</param>
        /// <returns></returns>
        public async Task<Sentinel> GetSentinelDataAsync(string uniqueName, LanguageType lan = LanguageType.Zh)
        {
            return await GetLibData<Sentinel>(uniqueName, "Sentinels", lan);
        }
    }
}
