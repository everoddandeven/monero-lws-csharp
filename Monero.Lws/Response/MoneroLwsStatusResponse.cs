using System.Text.Json.Serialization;

namespace Monero.Lws.Response;

public class MoneroLwsStatusResponse
{
    [JsonPropertyName("status")] public string Status { get; set; } = "";
}