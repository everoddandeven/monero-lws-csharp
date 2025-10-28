using System.Text.Json.Serialization;

namespace Monero.Lws.Common;

public class MoneroLwsRandomOutput
{
    [JsonPropertyName("global_index")] public string GlobalIndex { get; set; } = "";
    [JsonPropertyName("public_key")] public string PublicKey { get; set; } = "";
    [JsonPropertyName("rct")] public string Rct { get; set; } = "";
}