using System;
using System.Collections.Generic;
using System.Text;

namespace WarframeAlertingPrime.SDK.Models.Enums
{
    public enum RMOrderStatus
    {
        /// <summary>
        /// 新卡
        /// </summary>
        New,
        /// <summary>
        /// 交易中（商家发起交易请求，等待客户确认）
        /// </summary>
        Trading,
        /// <summary>
        /// 交易结束
        /// </summary>
        Done,
        /// <summary>
        /// 暂时下架
        /// </summary>
        Suspend,
        /// <summary>
        /// 永久下架
        /// </summary>
        Off
    }
    public enum WMOrderStatus
    {
        InGame,
        Online,
        Offline
    }
}
