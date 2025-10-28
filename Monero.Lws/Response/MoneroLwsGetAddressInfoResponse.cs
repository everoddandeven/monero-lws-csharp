using System.Text.Json.Serialization;
using Monero.Lws.Common;

namespace Monero.Lws.Response;

public class MoneroLwsGetAddressInfoResponse
{
    [JsonPropertyName("locked_funds")] public string LockedFunds { get; set; } = "";
    [JsonPropertyName("total_received")] public string TotalReceived { get; set; } = "";
    [JsonPropertyName("total_sent")] public string TotalSent { get; set; } = "";
    [JsonPropertyName("scanned_height")] public long ScannedHeight { get; set; } = 0;
    [JsonPropertyName("scanned_block_height")] public long ScannedBlockHeight { get; set; } = 0;
    [JsonPropertyName("start_height")] public long StartHeight { get; set; } = 0;
    [JsonPropertyName("transaction_height")] public long TransactionHeight { get; set; } = 0;
    [JsonPropertyName("blockchain_height")] public long BlockchainHeight { get; set; } = 0;
    [JsonPropertyName("spent_outputs")] public List<MoneroLwsSpend> SpentOutputs { get; set; } = [];
    [JsonPropertyName("rates")] public MoneroLwsRates? Rates { get; set; } = null;
}
