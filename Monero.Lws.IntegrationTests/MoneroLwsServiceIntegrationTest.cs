using Monero.Lws.IntegrationTests.Utils;

namespace Monero.Lws.IntegrationTests;

public class MoneroLwsServiceIntegrationTest
{
    private static readonly string Address = TestUtils.Address;
    private static readonly string ViewKey = TestUtils.ViewKey;
    private static readonly MoneroLwsService Lws = TestUtils.GetLwsService();

    [Fact]
    public async Task TestGetVersion()
    {
        var response = await Lws.GetVersion();
        
        Assert.NotNull(response.ServerType);
        Assert.NotNull(response.ServerVersion);
        Assert.NotNull(response.LastGitCommitHash);
        Assert.NotNull(response.LastGitCommitDate);
        Assert.NotNull(response.GitBranchName);
        Assert.NotNull(response.NetworkType);
        Assert.NotEmpty(response.ServerType);
        Assert.NotEmpty(response.ServerVersion);
        Assert.NotEmpty(response.LastGitCommitHash);
        Assert.NotEmpty(response.LastGitCommitDate);
        Assert.NotEmpty(response.GitBranchName);
        Assert.NotEmpty(response.NetworkType);
        Assert.True(response.BlockchainHeight > 0);
        Assert.True(response.Api > 0);
        Assert.True(response.MaxSubaddresses > 0);
        Assert.False(response.Testnet);
    }
    
    [Fact]
    public async Task TestLogin()
    {
        var response = await Lws.Login(Address, ViewKey, true, false);
        
        Assert.True(response.StartHeight > 0);
        Assert.True(response.NewAddress);
        Assert.False(response.GeneratedLocally);
    }

    [Fact]
    public async Task TestGetAddressInfo()
    {
        var response = await Lws.GetAddressInfo(Address, ViewKey);
        Assert.True(response.StartHeight > 0);
        Assert.True(response.BlockchainHeight > 0);
        Assert.True(response.ScannedBlockHeight > 0);
        Assert.True(response.ScannedHeight > 0);
        Assert.Equal(0, response.TransactionHeight);
        Assert.Equal("0", response.LockedFunds);
        Assert.Equal("0", response.TotalReceived);
        Assert.Equal("0", response.TotalSent);
        Assert.Null(response.Rates);
    }

    [Fact]
    public async Task TestGetAddressTxs()
    {
        var response = await Lws.GetAddressTxs(Address, ViewKey);
    }

    [Fact]
    public async Task TestGetUnspentOuts()
    {
        var response = await Lws.GetUnspentOuts(Address, ViewKey, "0", 0, true);
    }
    
}