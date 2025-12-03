using System.Text.Json.Serialization;

namespace Monero.Lws.Common;

public class MoneroLwsSubaddrsEntry
{
    [JsonPropertyName("key")] public long AccountIndex { get; set; } = 0;
    [JsonPropertyName("index_range")] public List<MoneroLwsAddressIndexRange> Ranges = [];
}