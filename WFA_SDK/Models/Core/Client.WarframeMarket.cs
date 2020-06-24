using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarframeAlertingPrime.SDK.Models.Enums;
using WarframeAlertingPrime.SDK.Models.Others;
using WarframeAlertingPrime.SDK.Models.WarframeMarket;
using WarframeAlertingPrime.SDK.Tools;

namespace WarframeAlertingPrime.SDK.Models.Core
{
    public partial class Client
    {
        /// <summary>
        /// Get orders from Warframe Market. the query code can get from Sale Dictionary.
        /// </summary>
        /// <param name="option">Query paramters</param>
        /// <returns></returns>
        public async Task<OrderQueryResult> GetWarframeMarketOrdersAsync(WarframeMarketOrderQueryOption option)
        {
            if (string.IsNullOrEmpty(option.Code))
                throw new ArgumentNullException("The item code must be valid.");
            string route = Statics.WM_ORDER_QUERY_URL + $"{option.Code}?platform={Platform}&pageSize={option.PageSize}" +
                         $"&page={option.Page}&type={option.Type.ToString().ToLower()}&status={string.Join("&status=", option.OrderStatus.Select(p => p.ToString().ToLower()))}" +
                         $"&minPrice={option.MinPrice}&maxPrice={option.MaxPrice}";
            if (option.ModRank > 0)
                route += $"&rank={option.ModRank}";
            var orders = await NetworkTools.GetEntityAsync<OrderQueryResult>(route, Token, ExceptionAction);
            return orders;
        }

        /// <summary>
        /// Get Related items from Warframe Market. the query code can get from Sale Dictionary.
        /// </summary>
        /// <param name="code">Item code</param>
        /// <returns></returns>
        public async Task<List<Item>> GetWarframeMarketItemsSetAsync(string code)
        {
            if (string.IsNullOrEmpty(code))
                throw new ArgumentNullException("The item code must be valid.");
            string route = Statics.WM_ORDER_QUERY_URL + $"{code}?platform={Platform}";
            var items = await NetworkTools.GetEntityAsync<List<Item>>(route, Token, ExceptionAction);
            return items;
        }

        /// <summary>
        /// Get lastest orders from Warframe Market. If you need special order type, please set the orderType paramter
        /// </summary>
        /// <param name="orderType">Order type</param>
        /// <returns></returns>
        public async Task<List<Order>> GetWarframeMarketLastestOrdersAsync(OrderType? orderType = null)
        {
            string route = Statics.WM_LASTEST_ORDERS_URL + $"?platform={Platform}";
            var orders = new List<Order>();
            if (orderType != null)
            {
                route += $"&type={orderType.ToString().ToLower()}";
                orders = await NetworkTools.GetEntityAsync<List<Order>>(route, Token, ExceptionAction);
            }
            else
            {
                var data = await NetworkTools.GetEntityAsync<RecentOrders>(route, Token, ExceptionAction);
                orders = orders.Union(data.Sell).Union(data.Buy).ToList();
            }
            return orders;
        }

        /// <summary>
        /// Get order history statistics data from Warframe Market. 
        /// </summary>
        /// <param name="code">Item code</param>
        /// <param name="type">Chart data are from live or closed</param>
        /// <returns></returns>
        public async Task<Statistics> GetWarframeMarketStatisticsAsync(string code, StatisticsType type)
        {
            string route = Statics.WM_STATISTICS_URL + $"{code}?platform={Platform}&type={type.ToString().ToLower()}";
            var data = await NetworkTools.GetEntityAsync<Statistics>(route, Token, ExceptionAction);
            return data;
        }

        /// <summary>
        /// Get user profile which from Warframe Market and include the orders.
        /// </summary>
        /// <param name="name">User game name</param>
        /// <returns></returns>
        public async Task<ProfileWithOrders> GetWarframeMarketUserProfileAsync(string name)
        {
            string route = Statics.WM_USER_URL + $"{name}?platform={Platform}";
            var profile = await NetworkTools.GetEntityAsync<ProfileWithOrders>(route, Token, ExceptionAction);
            return profile;
        }

        /// <summary>
        /// Get ducats price which from Warframe Market.
        /// </summary>
        /// <returns></returns>
        public async Task<DucatPricePayload> GetWarframeMarketDucatsPriceAsync()
        {
            string route = Statics.WM_DUCAT_TOOL + $"?platform={Platform}";
            var profile = await NetworkTools.GetEntityAsync<DucatPricePayload>(route, Token, ExceptionAction);
            return profile;
        }
    }
}
