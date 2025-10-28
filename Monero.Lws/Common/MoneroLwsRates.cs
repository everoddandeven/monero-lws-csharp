using System.Text.Json.Serialization;

namespace Monero.Lws.Common;

public class MoneroLwsRates
{
    [JsonPropertyName("AUD")] public float? Aud { get; set; } = null;
    [JsonPropertyName("BRL")] public float? Brl { get; set; } = null;
    [JsonPropertyName("BTC")] public float? Btc { get; set; } = null;
    [JsonPropertyName("CAD")] public float? Cad { get; set; } = null;
    [JsonPropertyName("CHF")] public float? Chf { get; set; } = null;
    [JsonPropertyName("CNY")] public float? Cny { get; set; } = null;
    [JsonPropertyName("EUR")] public float? Eur { get; set; } = null;
    [JsonPropertyName("GBP")] public float? Gbp { get; set; } = null;
    [JsonPropertyName("HKD")] public float? Hkd { get; set; } = null;
    [JsonPropertyName("INR")] public float? Inr { get; set; } = null;
    [JsonPropertyName("JPY")] public float? Jpy { get; set; } = null;
    [JsonPropertyName("KRW")] public float? Krw { get; set; } = null;
    [JsonPropertyName("MXN")] public float? Mxn { get; set; } = null;
    [JsonPropertyName("NOK")] public float? Nok { get; set; } = null;
    [JsonPropertyName("NZD")] public float? Nzd { get; set; } = null;
    [JsonPropertyName("SEK")] public float? Sek { get; set; } = null;
    [JsonPropertyName("SGD")] public float? Sgd { get; set; } = null;
    [JsonPropertyName("TRY")] public float? Try { get; set; } = null;
    [JsonPropertyName("USD")] public float? Usd { get; set; } = null;
    [JsonPropertyName("RUB")] public float? Rub { get; set; } = null;
    [JsonPropertyName("ZAR")] public float? Zar { get; set; } = null;
}