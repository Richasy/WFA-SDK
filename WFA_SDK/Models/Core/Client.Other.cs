using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WarframeAlertingPrime.SDK.Models.Meta;
using WarframeAlertingPrime.SDK.Models.Others;
using WarframeAlertingPrime.SDK.Tools;

namespace WarframeAlertingPrime.SDK.Models.Core
{
    public partial class Client
    {
        /// <summary>
        /// Get version information of WFA thesaurus
        /// </summary>
        /// <returns></returns>
        public async Task<List<Meta.Meta>> GetMetaVersion()
        {
            var metas = await NetworkTools.GetEntityAsync<List<Meta.Meta>>(Statics.APP_META_VERSION_URL, Token, ExceptionAction);
            return metas;
        }
        /// <summary>
        /// Analyze Translation Thesaurus
        /// </summary>
        /// <param name="json">Thesaurus file (json format)</param>
        /// <returns></returns>
        public List<Dict> ParseDictJson(string json)
        {
            if (string.IsNullOrEmpty(json))
                json = "[]";
            return JsonConvert.DeserializeObject<List<Dict>>(json);
        }
        /// <summary>
        /// Analyze Warframe Market Items Thesaurus
        /// </summary>
        /// <param name="json">Thesaurus file (json format)</param>
        /// <returns></returns>
        public List<Sale> ParseSaleJson(string json)
        {
            if (string.IsNullOrEmpty(json))
                json = "[]";
            return JsonConvert.DeserializeObject<List<Sale>>(json);
        }
        /// <summary>
        /// Analyze Invasion Thesaurus
        /// </summary>
        /// <param name="json">Thesaurus file (json format)</param>
        /// <returns></returns>
        public List<Dict> ParseInvasionRewardJson(string json)
        {
            return ParseDictJson(json);
        }
        /// <summary>
        /// Analyze Night Wave Thesaurus
        /// </summary>
        /// <param name="json">Thesaurus file (json format)</param>
        /// <returns></returns>
        public List<Dict> ParseNightwaveJson(string json)
        {
            return ParseDictJson(json);
        }
        /// <summary>
        /// Analyze Riven Weapon Thesaurus
        /// </summary>
        /// <param name="json">Thesaurus file (json format)</param>
        /// <returns></returns>
        public List<Riven> ParseRivenJson(string json)
        {
            if (string.IsNullOrEmpty(json))
                json = "[]";
            return JsonConvert.DeserializeObject<List<Riven>>(json);
        }
        /// <summary>
        /// Analyze Lib Index Thesaurus
        /// </summary>
        /// <param name="json">Thesaurus file (json format)</param>
        /// <returns></returns>
        public List<Meta.Lib> ParseLibJson(string json)
        {
            if (string.IsNullOrEmpty(json))
                json = "[]";
            return JsonConvert.DeserializeObject<List<Meta.Lib>>(json);
        }
    }
}
