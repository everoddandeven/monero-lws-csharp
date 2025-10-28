using System.Text.Json.Serialization;
using Monero.Lws.Common;

namespace Monero.Lws.Response;

public class MoneroLwsGetRandomOutsResponse
{
    [JsonPropertyName("amount_outs")] public List<MoneroLwsRandomOutput> AmountOuts { get; set; } = [];
}