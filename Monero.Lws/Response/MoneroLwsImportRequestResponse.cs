using System.Text.Json.Serialization;

namespace Monero.Lws.Response;

public class MoneroLwsImportRequestResponse : MoneroLwsStatusResponse
{
    [JsonPropertyName("payment_address")] public string? PaymentAddress { get; set; } = null;
    [JsonPropertyName("payment_id")] public string? PaymentId { get; set; } = null;
    [JsonPropertyName("import_fee")] public string? ImportFee { get; set; } = null;
    [JsonPropertyName("new_request")] public bool NewRequest { get; set; } = false;
}