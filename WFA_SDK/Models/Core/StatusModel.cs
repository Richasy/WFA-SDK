using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeAlertingPrime.SDK.Models.Core
{
    public class StatusModel
    {
        public int Code { get; set; }
        public bool IsSuccessed { get; set; }
        public CodeModel Messages { get; set; }
        public StatusModel()
        {

        }
        public StatusModel(int code, bool isSuccessed)
        {
            Code = code;
            Messages = new CodeModel(code);
            IsSuccessed = isSuccessed;
        }
        public static StatusModel NoAccessTokenError = new StatusModel(600, false);
        public static StatusModel NetworkError = new StatusModel(601, false);
    }
    public class CodeModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public CodeModel()
        {

        }
        public CodeModel(int code)
        {
            switch (code)
            {
                case 600:
                    Title = "No AccessToken";
                    Description = "Don't have the access token";
                    break;
                case 601:
                    Title = "Network Error";
                    Description = "Can't get the data from web";
                    break;
            }
        }
    }
}
