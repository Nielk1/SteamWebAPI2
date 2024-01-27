using System;

namespace Steam.Models.GameServers
{
    public enum ERegion : byte
    {
        USEast = 0x00,
        USWest = 0x01,
        SouthAmerica = 0x02,
        Europe = 0x03,
        Asia = 0x04,
        Australia = 0x05,
        MiddleEast = 0x06,
        Africa = 0x07,
        World = 0xFF
    }
    public class GetServerListModel
    {
        public GetServerModel[] Servers { get; set; }
    }
    public class GetServerModel
    {
        public string Address { get; set; }
        public UInt16 GamePort { get; set; }
        public string SteamId { get; set; }
        public string Name { get; set; }
        public UInt32 AppId { get; set; }
        public string GameDir { get; set; }
        public string Version { get; set; }
        public string Product { get; set; }
        public ERegion Region { get; set; }
        public UInt32 Players { get; set; }
        public UInt32 MaxPlayers { get; set; }
        public UInt32 Bots { get; set; }
        public string Map { get; set; }
        public bool Secure { get; set; }
        public bool Dedicated { get; set; }
        public char OS { get; set; }
        public string GameType { get; set; }
    }
}
