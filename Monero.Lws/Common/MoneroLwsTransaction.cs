using System.Text.Json.Serialization;

namespace Monero.Lws.Common;

public class MoneroLwsTransaction
{
    [JsonPropertyName("id")] public long Id { get; set; } = 0;
    [JsonPropertyName("hash")] public string Hash { get; set; } = "";
    [JsonPropertyName("timestamp")] public string? Timestamp { get; set; } = null;
    [JsonPropertyName("total_received")] public string TotalReceived { get; set; } = "";
    [JsonPropertyName("total_sent")] public string TotalSent { get; set; } = "";
    [JsonPropertyName("unlock_time")] public long UnlockTime { get; set; } = 0;
    [JsonPropertyName("height")] public long? Height { get; set; } = null;
    [JsonPropertyName("spent_outputs")] public List<MoneroLwsSpend> SpentOutputs { get; set; } = [];
    [JsonPropertyName("payment_id")] public string? PaymentId { get; set; } = null;
    [JsonPropertyName("coinbase")] public bool Coinbase { get; set; } = false;
    [JsonPropertyName("mempool")] public bool Mempool { get; set; } = false;
    [JsonPropertyName("mixin")] public int Mixin { get; set; } = 0;
}
