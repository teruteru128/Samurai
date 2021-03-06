using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Newtonsoft.Json;

namespace AcidChicken.Samurai.Models
{
    [JsonObject]
    public class Config
    {
        [JsonProperty("busy")]
        public ulong Busy { get; set; } = ulong.MaxValue;

        [JsonProperty("default_settings")]
        public Dictionary<string, string> DefaultSettings { get; set; } = new Dictionary<string, string>();

        [JsonProperty("discord_token")]
        public string DiscordToken { get; set; } = "";

        [JsonProperty("last_posts")]
        public Dictionary<ulong, Dictionary<ulong, DateTimeOffset>> LastPosts { get; set; } = new Dictionary<ulong, Dictionary<ulong, DateTimeOffset>>();

        [JsonProperty("managers")]
        public HashSet<ulong> Managers { get; set; } = new HashSet<ulong>();

        [JsonProperty("notification_channels")]
        public HashSet<ulong> NotificationChannels { get; set; } = new HashSet<ulong>();

        [JsonProperty("prefix_overrides")]
        public Dictionary<ulong, string> PrefixOverrides { get; set; } = new Dictionary<ulong, string>();

        [JsonProperty("rpc_password")]
        public string RpcPassword { get; set; } = "";

        [JsonProperty("rpc_server")]
        public string RpcServer { get; set; } = "http://127.0.0.1:9305";

        [JsonProperty("rpc_user")]
        public string RpcUser { get; set; } = "";

        [JsonProperty("targets")]
        public Dictionary<string, Monitor> Monitors { get; set; } = new Dictionary<string, Monitor>();

        [JsonProperty("user_settings")]
        public Dictionary<ulong, Dictionary<string, string>> Settings { get; set; } = new Dictionary<ulong, Dictionary<string, string>>();
    }

    [JsonObject]
    public class Monitor
    {
        public Monitor(string hostname = "", IPStatus lastStatus = IPStatus.Unknown)
        {
            Hostname = hostname;
            LastStatus = lastStatus;
        }

        [JsonProperty("hostname")]
        public string Hostname { get; set; } = "";

        [JsonProperty("last_status")]
        public IPStatus LastStatus { get; set; } = IPStatus.Unknown;
    }
}
