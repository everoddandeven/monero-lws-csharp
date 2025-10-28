using System.Text.Json.Serialization;

namespace Monero.Lws.Common;

public class MoneroLwsRandomOutputs
{
    [JsonPropertyName("amount")] public string Amount { get; set; } = "";
    [JsonPropertyName("outputs")] public List<MoneroLwsRandomOutput>? Outputs { get; set; } = null;
}