using System.Text.Json.Serialization;

namespace Tectum.PublicBlockChainClient.Requests;

/// <summary>
/// GET /coins/balances: Retrieve balances for multiple tokens
/// </summary>
public class GetCoinsBalancesRequest
{
    [JsonPropertyName("address")]
    public string Address { get; set; } = null!;
}