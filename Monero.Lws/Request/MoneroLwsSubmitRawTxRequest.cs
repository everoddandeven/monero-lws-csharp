using System.Text.Json.Serialization;

namespace Monero.Lws.Request;

public class MoneroLwsSubmitRawTxRequest
{
    [JsonPropertyName("tx")] public string Tx { get; set; } = "";
}