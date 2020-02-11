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
        private string _clientId;
        private string _clientSecret;
        private string[] _permissions;
        public string Platform { get; }
        /// <summary>
        /// Token provided by WFA, valid for two weeks
        /// </summary>
        public string Token { get; set; }
        private Action<StatusModel> ExceptionAction = new Action<StatusModel>((mod) =>
        {
            var args = new ExceptionEventArgs(mod);
            OnException?.Invoke(null, args);
        });
        /// <summary>
        /// Initializing a client will request a new token
        /// </summary>
        /// <param name="clientId">Client Id</param>
        /// <param name="clientSecret">Client Secret</param>
        /// <param name="permissions">Permissions, optional values are <c>wfa.basic</c>, <c>wfa.lib.query</c>, <c>wfa.riven.query</c>, <c>wfa.user.read</c></param>
        /// <param name="platform">Information platform</param>
        public Client(string clientId, string clientSecret, string[] permissions, PlatformType platform = PlatformType.PC)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _permissions = permissions;
            Platform = TransPlatform(platform);
        }
        /// <summary>
        /// An error occurred during data processing
        /// </summary>
        public static event EventHandler<ExceptionEventArgs> OnException;
        /// <summary>
        /// Initializing a client
        /// </summary>
        /// <param name="token">Valid token value</param>
        /// <param name="platform">Information platform</param>
        public Client(string token, PlatformType platform = PlatformType.PC)
        {
            Token = token;
            Platform = TransPlatform(platform);
        }
        /// <summary>
        /// Used to generate tokens or verify the validity of tokens
        /// </summary>
        /// <returns>Validation results</returns>
        public async Task<InitResultType> InitAsync()
        {
            InitResultType result = InitResultType.Success;
            if (string.IsNullOrEmpty(Token))
            {
                var token = await NetworkTools.GetClientCredentialsToken(_clientId, _clientSecret, _permissions, (msg) =>
                  {
                      var args = new ExceptionEventArgs(msg);
                      OnException?.Invoke(this, args);
                  });
                if (token.IsError)
                {
                    if (token.ErrorType == IdentityModel.Client.ResponseErrorType.Http)
                        result = InitResultType.HttpError;
                    else
                        result = InitResultType.InvalidParameters;
                }
                else
                {
                    Token = token.AccessToken;
                    result = InitResultType.Success;
                }
            }
            else
            {
                string testRoute = "basic/earthStatus";
                await NetworkTools.GetEntityAsync<EarthStatus>(testRoute, Token, (msg) =>
                {
                    if (msg.Code == 601)
                        result = InitResultType.HttpError;
                    else
                        result = InitResultType.TokenExpiry;
                });
            }
            return result;
        }
    
        private string TransPlatform(PlatformType platfrom)
        {
            string result = platfrom.ToString().ToLower();
            if (platfrom == PlatformType.Switch)
                result = "swi";
            return result;
        }
    }
}
