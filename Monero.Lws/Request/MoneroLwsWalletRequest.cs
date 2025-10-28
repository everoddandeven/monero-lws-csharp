using System.Text.Json.Serialization;

namespace Monero.Lws.Request;

public class MoneroLwsWalletRequest
{
    [JsonPropertyName("address")] public string Address { get; set; } = "";
    [JsonPropertyName("view_key")] public string ViewKey { get; set; } = "";
}