using System.Text.Json.Serialization;

namespace Monero.Lws.Common;

public class MoneroLwsOutput
{
    [JsonPropertyName("tx_id")] public long TxId { get; set; } = 0;
    [JsonPropertyName("amount")] public string Amount { get; set; } = "";
    [JsonPropertyName("index")] public long Index { get; set; } = 0;
    [JsonPropertyName("global_index")] public long GlobalIndex { get; set; } = 0;
    [JsonPropertyName("rct")] public string Rct { get; set; } = "";
    [JsonPropertyName("tx_hash")] public string TxHash { get; set; } = "";
    [JsonPropertyName("tx_prefix_hash")] public string TxPrefixHash { get; set; } = "";
    [JsonPropertyName("public_key")] public string PublicKey { get; set; } = "";
    [JsonPropertyName("tx_pub_key")] public string TxPubKey { get; set; } = "";
    [JsonPropertyName("spend_key_images")] public List<string> SpendKeyImages { get; set; } = [];
    [JsonPropertyName("timestamp")] public string Timestamp { get; set; } = "";
    [JsonPropertyName("height")] public long Height { get; set; } = 0;
}
