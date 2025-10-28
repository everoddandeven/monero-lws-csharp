using System.Text.Json.Serialization;

namespace Monero.Lws.Request;

public class MoneroLwsGetUnspentOutsRequest
{
    [JsonPropertyName("amount")] public string Amount { get; set; } = "";
    [JsonPropertyName("mixin")] public int Mixin { get; set; } = 0;
    [JsonPropertyName("use_dust")] public bool UseDust { get; set; } = true;
    [JsonPropertyName("dust_threshold")] public string? DustThreshold { get; set; } = null;
}