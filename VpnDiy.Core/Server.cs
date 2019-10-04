using System;

namespace VpnDiy
{
    public class Server
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string State { get; set; }

        public string PublicDns { get; set; }

        public string IP { get; set; }

        public DateTime LaunchTime { get; set; }
    }

    public class ServerExtension
    {
        public string Id { get; set; }
        public bool IpCopied { get; set; }
        public bool ShadowsocksRestarted { get; set; }
    }
}
