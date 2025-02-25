using FluentAssertions;
using Tectum.PublicBlockChainClient.Requests;
using Tectum.PublicBlockChainClient.Responses.Dtos;

namespace Tectum.PublicBlockChainClient.Tests;

/// <summary>
/// For this test you have to start node on local computer or using public node
/// </summary>
public class PublicBlockChainClientTests
{
    private string _addressNode = "http://127.0.0.1:8917";
    private PublicBlockChainClient _publicBlockChain;

    [SetUp]
    public void Setup()
    {
        var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri(_addressNode);

        _publicBlockChain = new PublicBlockChainClient(httpClient);
    }

    [Ignore("Need using real Tectum 4.0 Node")]
    [Test]
    public async Task GetCoinBalancesAsync_Success()
    {
        var result = await _publicBlockChain.GetCoinBalancesAsync(new GetCoinsBalancesRequest
        {
            Address = "0xe38465d9ea628bbe533067e0395f66212b723873"
        });

        result.Should().NotBeNull();
        result!.HasError.Should().BeFalse();
        result.Balance.Should().BeGreaterThan(1000000);
    }

    [Ignore("Need using real Tectum 4.0 Node")]
    [Test]
    public async Task GetCoinTransfersAsync_Success()
    {
        var result = await _publicBlockChain.GetCoinTransfersAsync(new GetCoinsTransfersRequest
        {
            Rows = 10,
            Skip = 1
        });

        result.Should().NotBeNull();
        result.HasError.Should().BeFalse();
        result.Transactions!.Count.Should().Be(10);

        AssetTransactions(result.Transactions!);
    }

    //[Ignore("Need using real Tectum 4.0 Node")]
    [TestCase(12)]
    public async Task GetCoinTransferAsync_Success(long blockId)
    {
        var result = await _publicBlockChain.GetCoinTransferAsync(blockId);

        result.Should().NotBeNull();
        result.HasError.Should().BeFalse();
        result.AddressFrom.Should().NotBeNullOrWhiteSpace();
        result.AddressTo.Should().NotBeNullOrWhiteSpace();
        result.Hash.Should().NotBeNullOrWhiteSpace();
        result.Block.Should().Be(blockId);
        result.Fee.Should().BeGreaterThan(100000);
        result.Amount.Should().BeGreaterThan(1000000);
        result.Sign.Should().NotBeNullOrWhiteSpace();
        result.Sign.Length.Should().Be(144);
        result.PreviousHash.Should().NotBeNullOrWhiteSpace();
        result.PreviousHash.Length.Should().Be(64);
        result.TokenId.Should().Be(0);
        result.Rewards!.Archiver!.Sign.Should().NotBeNullOrWhiteSpace();
        result.Rewards!.Archiver!.Sign.Length.Should().Be(144);
        result.Rewards!.Archiver!.Address.Should().NotBeNullOrWhiteSpace();
        result.Rewards!.Archiver!.Address.Length.Should().Be(40);
        result.Rewards!.Archiver!.Amount.Should().BeGreaterThan(1000000);

        result.Rewards!.Validators!.Count.Should().Be(3);
        foreach (var validator in result.Rewards!.Validators)
        {
            validator.Amount.Should().BeGreaterThan(1000000);
            validator.Address.Should().NotBeNullOrWhiteSpace();
            validator.Address.Length.Should().Be(40);
            validator.Sign.Should().NotBeNullOrWhiteSpace();
            validator.Sign.Length.Should().Be(144);
        }
    }

    private void AssetTransactions(List<CoinTransferDto> transactions)
    {
        var blockNum = transactions[0].Block;

        foreach (var transaction in transactions)
        {
            transaction.Amount.Should().BeGreaterThan(1000);
            transaction.Fee.Should().BeGreaterThan(1000);
            transaction.Block.Should().Be(blockNum);
            transaction.Date.Should().BeGreaterThan(1000000);
            transaction.Hash.Should().NotBeNullOrWhiteSpace();
            transaction.AddressFrom.Should().NotBeNullOrWhiteSpace();
            transaction.AddressTo.Should().NotBeNullOrWhiteSpace();
            blockNum--;
        }
    }
}