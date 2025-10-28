using System.Text.Json.Serialization;

namespace Monero.Lws.Request;

public class MoneroLwsGetRandomOutsRequest
{
    [JsonPropertyName("count")] public long Count { get; set; } = 0;
    [JsonPropertyName("amounts")] public List<string> Amounts { get; set; } = [];
}