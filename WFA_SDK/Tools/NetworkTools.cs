using IdentityModel.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WarframeAlertingPrime.SDK.Models.Core;

namespace WarframeAlertingPrime.SDK.Tools
{
    internal class NetworkTools
    {
        private const string _baseUrl = "https://data.richasy.cn/wfa/";
        private const string _identityUrl = "https://identity.richasy.cn/";
        /// <summary>
        /// 通过客户端方式获取授权令牌
        /// </summary>
        /// <param name="ErrorHandle">错误处理</param>
        /// <returns></returns>
        public static async Task<TokenResponse> GetClientCredentialsToken(string ClientId, string ClientSecret, string[] Scopes,Action<string> ErrorHandle = null)
        {
            var client = new HttpClient();
            using (client)
            {
                var response = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
                {
                    Address = _identityUrl + "connect/token",
                    ClientId = ClientId,
                    ClientSecret = ClientSecret,
                    Scope = string.Join(" ", Scopes)
                });
                return response;
            }
        }
        /// <summary>
        /// 从网络获取json数据并转化为实体
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="route">路由</param>
        /// <param name="token">令牌</param>
        /// <param name="MessageHandle">消息处理</param>
        /// <returns></returns>
        public static async Task<T> GetEntityAsync<T>(string route, string token, Action<StatusModel> MessageHandle = null) where T : class
        {
            var client = new HttpClient();
            using (client)
            {
                if (!string.IsNullOrEmpty(token))
                    client.SetBearerToken(token);
                try
                {
                    var response = await client.GetAsync(_baseUrl + route);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        if (typeof(T).Equals(typeof(string)))
                            return result as T;
                        var data = JsonConvert.DeserializeObject<T>(result);
                        if (data == null)
                        {
                            var msg = JsonConvert.DeserializeObject<StatusModel>(result);
                            MessageHandle?.Invoke(msg);
                        }
                        else
                            return data;
                    }
                    else
                    {
                        MessageHandle?.Invoke(StatusModel.NetworkError);
                    }
                }
                catch (Exception)
                {
                    MessageHandle?.Invoke(StatusModel.NetworkError);
                }
            }
            return null;
        }

    }
}
