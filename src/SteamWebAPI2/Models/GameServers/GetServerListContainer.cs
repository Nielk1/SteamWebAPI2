using Newtonsoft.Json;
using Steam.Models.GameServers;
using System;
using System.Collections.Generic;

namespace SteamWebAPI2.Models.GameServers
{
    public class GetServerListContainer
    {
        [JsonProperty("response")]
        public GetServerListResponse Response { get; set; }
    }

    public class GetServerListResponse
    {
        [JsonProperty("servers")]
        public GetServerResponse[] Servers { get; set; }
    }

    public class GetServerResponse
    {
        [JsonProperty("addr")]
        public string Address { get; set; }
        [JsonProperty("gameport")]
        public UInt16 GamePort { get; set; }
        [JsonProperty("steamid")]
        public string SteamId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("appid")]
        public UInt32 AppId { get; set; }
        [JsonProperty("gamedir")]
        public string GameDir { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("product")]
        public string Product { get; set; }
        [JsonProperty("region")]
        public ERegion Region { get; set; }
        [JsonProperty("players")]
        public UInt32 Players { get; set; }
        [JsonProperty("max_players")]
        public UInt32 MaxPlayers { get; set; }
        [JsonProperty("bots")]
        public UInt32 Bots { get; set; }
        [JsonProperty("map")]
        public string Map { get; set; }
        [JsonProperty("secure")]
        public bool Secure { get; set; }
        [JsonProperty("dedicated")]
        public bool Dedicated { get; set; }
        [JsonProperty("os")]
        public char OS { get; set; }
        [JsonProperty("gametype")]
        public string GameType { get; set; }
    }
}
