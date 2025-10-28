using System.Text.Json.Serialization;

namespace Monero.Lws.Common;

public class MoneroLwsSpend
{
    [JsonPropertyName("amount")] public string Amount { get; set; } = "";
    [JsonPropertyName("key_image")] public string KeyImage { get; set; } = "";
    [JsonPropertyName("tx_pub_key")] public string TxPubKey { get; set; } = "";
    [JsonPropertyName("out_index")] public int OutIndex { get; set; } = 0;
    [JsonPropertyName("mixin")] public int Mixin { get; set; } = 0;
}
