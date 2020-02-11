using System;
using System.Collections.Generic;
using System.Text;
using WarframeAlertingPrime.SDK.Models.Core;

namespace WarframeAlertingPrime.SDK.Models.Others
{
    public class ExceptionEventArgs:EventArgs
    {
        public string Message { get; set; }
        public StatusModel Exception { get; set; }
        public ExceptionEventArgs()
        {

        }
        public ExceptionEventArgs(string msg)
        {
            Message = msg;
        }
        public ExceptionEventArgs(StatusModel model)
        {
            Exception = model;
            Message = model.Messages.Description;
        }
    }
}
