using System.Text.Json.Serialization;
using Monero.Lws.Common;

namespace Monero.Lws.Response;

public class MoneroLwsGetAddressTxsResponse
{
    [JsonPropertyName("total_received")] public string TotalReceived { get; set; } = "";
    [JsonPropertyName("scanned_height")] public long ScannedHeight { get; set; } = 0;
    [JsonPropertyName("scanned_block_height")] public long ScannedBlockHeight { get; set; } = 0;
    [JsonPropertyName("start_height")] public long StartHeight { get; set; } = 0;
    [JsonPropertyName("blockchain_height")] public long BlockchainHeight { get; set; } = 0;
    [JsonPropertyName("transactions")] public List<MoneroLwsTransaction> Transactions { get; set; } = [];
}