using System.Text.Json.Serialization;

namespace Monero.Lws.Request;

public class MoneroLwsLoginRequest : MoneroLwsWalletRequest
{
    [JsonPropertyName("create_account")] public bool CreateAccount { get; set; } = true;
    [JsonPropertyName("generated_locally")] public bool GeneratedLocally { get; set; } = true;
}