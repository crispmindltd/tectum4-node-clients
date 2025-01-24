using System.Collections.Generic;
using System.Text.Json.Serialization;
using Tectum.PublicBlockChainClient.Responses.Dtos;

namespace Tectum.PublicBlockChainClient.Responses
{
    /// <summary>
    /// Get all balances for coin
    /// </summary>
    public class GetCoinBalancesResponse : BaseResponse
    {
        [JsonPropertyName("balances")] 
        public List<BalanceDto> Balances { get; set; } = null!;
    }
}