using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WarframeAlertingPrime.SDK.Models.Enums;
using WarframeAlertingPrime.SDK.Models.GameInfo;
using WarframeAlertingPrime.SDK.Models.Others;
using WarframeAlertingPrime.SDK.Tools;

namespace WarframeAlertingPrime.SDK.Models.Core
{
    public partial class Client
    {
        private string InitRoute(string route)
        {
            return route + $"?platform={Platform}";
        }
        /// <summary>
        /// Get all game information
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetAllGameInfoAsync()
        {
            string gameInfo = await NetworkTools.GetEntityAsync<string>(InitRoute(Statics.ALL_GAMEINFO_URL), Token, ExceptionAction);
            return gameInfo;
        }
        /// <summary>
        /// Request Cetus day and night data online
        /// </summary>
        /// <returns></returns>
        public async Task<CetusStatus> GetCetusStatusAsync()
        {
            var cetus = await NetworkTools.GetEntityAsync<CetusStatus>(InitRoute(Statics.CETUS_URL), Token, ExceptionAction);
            return cetus;
        }
        /// <summary>
        /// Analyze Cetus day and night information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public CetusStatus GetCetusStatus(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var cetus = JsonConvert.DeserializeObject<CetusStatus>(jobj["cetusCycle"].ToString());
            return cetus;
        }
        /// <summary>
        /// Request Earth day and night data online
        /// </summary>
        /// <returns></returns>
        public async Task<EarthStatus> GetEarthStatusAsync()
        {
            var data = await NetworkTools.GetEntityAsync<EarthStatus>(InitRoute(Statics.EARTH_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze Earth day and night information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public EarthStatus GetEarthStatus(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<EarthStatus>(jobj["earthCycle"].ToString());
            return data;
        }
        /// <summary>
        /// Request Orb Vallis warm and cold data online
        /// </summary>
        /// <returns></returns>
        public async Task<VallisStatus> GetVallisStatusAsync()
        {
            var data = await NetworkTools.GetEntityAsync<VallisStatus>(InitRoute(Statics.VALLIS_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze Orb Vallis warm and cold information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public VallisStatus GetVallisStatus(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<VallisStatus>(jobj["vallisCycle"].ToString());
            return data;
        }
        /// <summary>
        /// Request arbitration data online
        /// </summary>
        /// <returns></returns>
        public async Task<Arbitration> GetArbitrationAsync()
        {
            var data = await NetworkTools.GetEntityAsync<Arbitration>(InitRoute(Statics.ARBITRATION_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze arbitration information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public Arbitration GetArbitration(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<Arbitration>(jobj["arbitration"].ToString());
            return data;
        }
        /// <summary>
        /// Request bounty data online
        /// </summary>
        /// <param name="region">Cetus or Fortuna</param>
        /// <param name="language">Reward display with Chinese or English</param>
        /// <returns></returns>
        public async Task<List<Bounty>> GetBountyAsync(BountyRegionType region, LanguageType language)
        {
            string re = region.ToString().ToLower();
            if (region == BountyRegionType.Fortuna)
                re = "solaris";
            string route = InitRoute(Statics.BOUNTY_URL) + $"&region={re}&language={language.ToString().ToLower()}";
            var data = await NetworkTools.GetEntityAsync<List<Bounty>>(route, Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Request Construction Progress data online
        /// </summary>
        /// <returns></returns>
        public async Task<ConstructionProgress> GetConstructionProgressAsync()
        {
            var data = await NetworkTools.GetEntityAsync<ConstructionProgress>(InitRoute(Statics.CONSTRUCTIONPROGRESS_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze Contruction Progress information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public ConstructionProgress GetConstructionProgress(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<ConstructionProgress>(jobj["constructionProgress"].ToString());
            return data;
        }
        /// <summary>
        /// Request news data online
        /// </summary>
        /// <returns></returns>
        public async Task<List<New>> GetNewsAsync()
        {
            var data = await NetworkTools.GetEntityAsync<List<New>>(InitRoute(Statics.NEWS_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze news information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public List<New> GetNews(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<List<New>>(jobj["news"].ToString());
            return data;
        }
        /// <summary>
        /// Request void trader data online
        /// </summary>
        /// <returns></returns>
        public async Task<VoidTrader> GetVoidTraderAsync()
        {
            var data = await NetworkTools.GetEntityAsync<VoidTrader>(InitRoute(Statics.VOIDTRADER_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze void trader information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public VoidTrader GetVoidTrader(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<VoidTrader>(jobj["voidTrader"].ToString());
            return data;
        }
        /// <summary>
        /// Request darvo daily deals data online
        /// </summary>
        /// <returns></returns>
        public async Task<Darvo> GetDarvoAsync()
        {
            var data = await NetworkTools.GetEntityAsync<Darvo>(InitRoute(Statics.DARVO_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze darvo daily deals information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public Darvo GetDarvo(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<Darvo>(jobj["dailyDeals"][0].ToString());
            return data;
        }
        /// <summary>
        /// Request alert data online
        /// </summary>
        /// <returns></returns>
        public async Task<List<Alert>> GetAlertsAsync()
        {
            var data = await NetworkTools.GetEntityAsync<List<Alert>>(InitRoute(Statics.ALERTS_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze alert information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public List<Alert> GetAlerts(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<List<Alert>>(jobj["alerts"].ToString());
            return data;
        }
        /// <summary>
        /// Request Invasion data online
        /// </summary>
        /// <returns></returns>
        public async Task<List<Invasion>> GetInvasionsAsync()
        {
            var data = await NetworkTools.GetEntityAsync<List<Invasion>>(InitRoute(Statics.INVASIONS_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze Invasion information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public List<Invasion> GetInvasions(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<List<Invasion>>(jobj["invasions"].ToString());
            return data;
        }
        /// <summary>
        /// Request Nightwave data online
        /// </summary>
        /// <returns></returns>
        public async Task<Nightwave> GetNightwavesAsync()
        {
            var data = await NetworkTools.GetEntityAsync<Nightwave>(InitRoute(Statics.NIGHTWAVE_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze Nightwave information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public Nightwave GetNightwaves(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<Nightwave>(jobj["nightwave"].ToString());
            return data;
        }
        /// <summary>
        /// Request Fissure data online
        /// </summary>
        /// <returns></returns>
        public async Task<List<Fissure>> GetFissuresAsync()
        {
            var data = await NetworkTools.GetEntityAsync<List<Fissure>>(InitRoute(Statics.FISSURES_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze Fissure information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public List<Fissure> GetFissures(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<List<Fissure>>(jobj["fissures"].ToString());
            return data;
        }
        /// <summary>
        /// Request Sortie data online
        /// </summary>
        /// <returns></returns>
        public async Task<Sortie> GetSortieAsync()
        {
            var data = await NetworkTools.GetEntityAsync<Sortie>(InitRoute(Statics.SORTIE_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze Sortie information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public Sortie GetSortie(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<Sortie>(jobj["sortie"].ToString());
            return data;
        }
        /// <summary>
        /// Request Event data online
        /// </summary>
        /// <returns></returns>
        public async Task<List<Event>> GetEventsAsync()
        {
            var data = await NetworkTools.GetEntityAsync<List<Event>>(InitRoute(Statics.EVENTS_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze Event information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public List<Event> GetEvents(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<List<Event>>(jobj["events"].ToString());
            return data;
        }
        /// <summary>
        /// Request ConclaveChallenge data online
        /// </summary>
        /// <returns></returns>
        public async Task<List<ConclaveChallenge>> GetConclaveChallengesAsync()
        {
            var data = await NetworkTools.GetEntityAsync<List<ConclaveChallenge>>(InitRoute(Statics.CONCLAVECHALLENGES_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze ConclaveChallenge information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public List<ConclaveChallenge> GetConclaveChallenges(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<List<ConclaveChallenge>>(jobj["conclaveChallenges"].ToString());
            return data;
        }
        /// <summary>
        /// Request Stalker data online
        /// </summary>
        /// <returns></returns>
        public async Task<List<Stalker>> GetStalkersAsync()
        {
            var data = await NetworkTools.GetEntityAsync<List<Stalker>>(InitRoute(Statics.STALKER_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze Stalker information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public List<Stalker> GetStalkers(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<List<Stalker>>(jobj["persistentEnemies"].ToString());
            return data;
        }
        /// <summary>
        /// Request Kuva data online
        /// </summary>
        /// <returns></returns>
        public async Task<List<Kuva>> GetKuvasAsync()
        {
            var data = await NetworkTools.GetEntityAsync<List<Kuva>>(InitRoute(Statics.KUVA_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze Kuva information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public List<Kuva> GetKuvas(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<List<Kuva>>(jobj["kuva"].ToString());
            return data;
        }
        /// <summary>
        /// Request Sentient Anomaly data online
        /// </summary>
        /// <returns></returns>
        public async Task<SentientAnomaly> GetSentientAnomalyAsync()
        {
            var data = await NetworkTools.GetEntityAsync<SentientAnomaly>(InitRoute(Statics.SENTIENT_URL), Token, ExceptionAction);
            return data;
        }
        /// <summary>
        /// Analyze Sentient Anomaly information from all game information
        /// </summary>
        /// <param name="totalGameInfo">all game information from <c>GetAllGameInfoAsync</c> method</param>
        /// <returns></returns>
        public SentientAnomaly GetSentientAnomaly(string totalGameInfo)
        {
            var jobj = JObject.Parse(totalGameInfo);
            var data = JsonConvert.DeserializeObject<SentientAnomaly>(jobj["sentientOutposts"].ToString());
            return data;
        }
    }
}
