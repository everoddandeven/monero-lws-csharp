namespace Monero.Lws.Common;

public class MoneroLwsApiException(int code, string message) : Exception(message)
{
    public readonly int Code = code;
}
