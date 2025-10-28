using System.Text.Json.Serialization;
using Monero.Lws.Common;

namespace Monero.Lws.Response;

public class MoneroLwsGetUnspentOutsResponse
{
    [JsonPropertyName("per_byte_fee")] public string PerByteFee { get; set; } = "";
    [JsonPropertyName("fee_mask")] public string FeeMask { get; set; } = "";
    [JsonPropertyName("amount")] public string Amount { get; set; } = "";
    [JsonPropertyName("outputs")] public List<MoneroLwsOutput> Outputs { get; set; } = [];
}