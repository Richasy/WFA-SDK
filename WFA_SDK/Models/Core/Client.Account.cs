using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WarframeAlertingPrime.SDK.Models.Others;
using WarframeAlertingPrime.SDK.Models.User;
using WarframeAlertingPrime.SDK.Tools;

namespace WarframeAlertingPrime.SDK.Models.Core
{
    public partial class Client
    {
        /// <summary>
        /// Get user information via UserId, This method can get the user's detailed information
        /// </summary>
        /// <param name="userId">User's unique identification</param>
        /// <returns></returns>
        public async Task<Account> GetUserFromIdAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException("userId", "Must provide a valid UserId");
            string route = Statics.USER_DETAIL_URL + $"?userId={userId}";
            var account = await NetworkTools.GetEntityAsync<Account>(route, Token, ExceptionAction);
            return account;
        }

        /// <summary>
        /// Fuzzy query for users by keywords.
        /// Keywords will match both diaplay name and game name, up to 10 people
        /// </summary>
        /// <param name="queryText">Query keywords</param>
        /// <returns></returns>
        public async Task<List<SlimAccount>> QueryUserByNameAsync(string queryText)
        {
            if (string.IsNullOrEmpty(queryText))
                throw new ArgumentNullException("queryText", "Must provide a valid query text");
            string route = Statics.USER_QUERY_URL + $"?user={WebUtility.UrlEncode(queryText)}";
            var accounts = await NetworkTools.GetEntityAsync<List<SlimAccount>>(route, Token, ExceptionAction);
            return accounts;
        }
        /// <summary>
        /// Get user listings and personal data in Riven Market by game name
        /// </summary>
        /// <param name="gameName">Game name</param>
        /// <returns></returns>
        public async Task<Profile> GetRivenProfileByGameNameAsync(string gameName)
        {
            if (string.IsNullOrEmpty(gameName))
                throw new ArgumentNullException("gameName", "Must provide a valid game name");
            string route = Statics.RIVENMARKET_PROFILE_URL + $"?user={WebUtility.UrlEncode(gameName)}";
            var profile = await NetworkTools.GetEntityAsync<Profile>(route, Token, ExceptionAction);
            return profile;
        }
        /// <summary>
        /// Get user listings and personal data in Riven Market by user id
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        public async Task<Profile> GetRivenProfileByUserIdAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException("userId", "Must provide a valid UserId");
            string route = Statics.RIVENMARKET_PROFILE_URL + $"?userId={userId}";
            var profile = await NetworkTools.GetEntityAsync<Profile>(route, Token, ExceptionAction);
            return profile;
        }
        /// <summary>
        /// Get the recommended price of the weapon or category, the price is divided into rolled and unrolled, and can be limited
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<List<Weekly>> GetRivenAdvicePricesAsync(RivenAdvicePriceOption option)
        {
            string route = Statics.RIVEMMARKET_ADVICE_PRICE_URL + $"?weapon={option.Weapon}&category={option.Category}";
            if (option.IsRerolled != null)
            {
                route += $"&rerolled={option.IsRerolled.ToString().ToLower()}";
            }
            var advices = await NetworkTools.GetEntityAsync<List<Weekly>>(route, Token, ExceptionAction);
            return advices;
        }

        /// <summary>
        /// Get the latest orders
        /// </summary>
        /// <param name="option">Request parameter</param>
        /// <returns></returns>
        public async Task<List<Order>> GetLastestRivenOrdersAsync(LastestRivenOrdersOption option)
        {
            if (option.OrderType.ToLower() != "sell" && option.OrderType.ToLower() != "buy")
                throw new ArgumentException("order type not valid");
            string route = Statics.RIVEMMARKET_LASTEST_ORDERS_URL + $"?orderType={option.OrderType}&pageSize={option.PageSize}&page={option.Page}";
            var orders = await NetworkTools.GetEntityAsync<List<Order>>(route, Token, ExceptionAction);
            return orders;
        }
        /// <summary>
        /// Query Riven Market Order
        /// </summary>
        /// <param name="option">Request parameter</param>
        /// <returns></returns>
        public async Task<OrderPackage> QueryRivenOrdersAsync(SearchRivenOrderOption option)
        {
            if (string.IsNullOrEmpty(option.Weapon) && string.IsNullOrEmpty(option.Category))
                throw new ArgumentException("must have valid weapon or category");
            string route=Statics.RIVEMMARKET_ORDER_QUERY_URL +
                    $"?orderType={option.OrderType}&pageSize={option.PageSize}&page={option.Page}" +
                    $"&category={option.Category}&weapon={option.Weapon}&isVeiled={option.IsVeiled}";
            var orders = await NetworkTools.GetEntityAsync<OrderPackage>(route, Token, ExceptionAction);
            return orders;
        }
    }
}
