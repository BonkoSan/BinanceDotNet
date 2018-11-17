﻿using System.Runtime.Serialization;

namespace BinanceExchange.API.Models.Response
{
   [DataContract]
    public class ExchangeInfoRateLimit
    {
        [DataMember(Order = 1)]
        public string RateLimitType { get; set; }

        [DataMember(Order = 2)]
        public string Interval { get; set; }

        [DataMember(Order = 3)]
        public int IntervalNum { get; set; }

        [DataMember(Order = 4)]
        public int Limit { get; set; }
    }
}
