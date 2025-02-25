using System.Text.Json.Serialization;

namespace Tectum.PublicBlockChainClient.Responses;

/// <summary>
/// Get all balances for coin
/// </summary>
public sealed class GetCoinBalancesResponse : BaseResponse
{
    [JsonPropertyName("balance")] 
    public long Balance { get; set; }
}