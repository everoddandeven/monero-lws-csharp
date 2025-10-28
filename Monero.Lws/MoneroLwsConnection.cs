using Monero.Lws.Response;

namespace Monero.Lws;

public class MoneroLwsConnection
{
    public async Task<MoneroLwsGetAddressInfoResponse> GetAddressInfo(string address, string viewKey)
    {
        throw new NotImplementedException();
    }

    public async Task<MoneroLwsGetAddressTxsResponse> GetAddressTxs(string address, string viewKey)
    {
        throw new NotImplementedException();
    }

    public async Task<MoneroLwsGetRandomOutsResponse> GetRandomOuts(long count, List<string> amounts)
    {
        throw new NotImplementedException();
    }

    public async Task<MoneroLwsGetUnspentOutsResponse> GetUnspentOuts(string address, string viewKey, string amount,
        int mixin, bool useDust, string? dustThreshold = null)
    {
        throw new NotImplementedException();
    }

    public async Task<MoneroLwsImportRequestResponse> ImportWallet(string address, string viewKey)
    {
        throw new NotImplementedException();
    }

    public async Task<MoneroLwsLoginResponse> Login(string address, string viewKey, bool createAccount,
        bool generatedLocally)
    {
        throw new NotImplementedException();
    }

    public async Task<MoneroLwsStatusResponse> SubmitRawTx(string tx)
    {
        throw new NotImplementedException();
    }
}