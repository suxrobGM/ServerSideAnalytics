using System;
using System.Net;

namespace ServerSideAnalytics
{
    public class WebRequest
    {
        public DateTime Timestamp { get; set; }

        public string Identity { get; set; }

        public IPAddress RemoteIpAddress { get; set; }

        public string Method { get; set; }

        public string Path { get; set; }

        public string UserAgent { get; set; }

        public string Referer { get; set; }

        public bool IsWebSocket { get; set; }

        public CountryCode CountryCode { get; set; }

    }
}