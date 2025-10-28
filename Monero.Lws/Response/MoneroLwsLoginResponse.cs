using System.Text.Json.Serialization;

namespace Monero.Lws.Response;

public class MoneroLwsLoginResponse
{
    [JsonPropertyName("new_address")] public bool NewAddress { get; set; } = false;
    [JsonPropertyName("generated_locally")] public bool? GeneratedLocally { get; set; } = null;
    [JsonPropertyName("start_height")] public long? StartHeight { get; set; } = null;
}