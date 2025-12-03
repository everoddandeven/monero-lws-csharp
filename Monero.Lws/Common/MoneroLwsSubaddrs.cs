using System.Text.Json.Serialization;

namespace Monero.Lws.Common;

public class MoneroLwsSubaddrs
{
    [JsonPropertyName("all_subaddrs")] public List<MoneroLwsSubaddrsEntry> AllSubaddrs = [];
    [JsonPropertyName("new_subaddrs")] public List<MoneroLwsSubaddrsEntry> NewSubaddrs = [];
}