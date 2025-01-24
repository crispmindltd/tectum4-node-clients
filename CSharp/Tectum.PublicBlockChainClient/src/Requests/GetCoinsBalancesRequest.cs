using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Requests
{
    /// <summary>
    /// GET /coins/balances: Retrieve balances for multiple tokens
    /// </summary>
    public class GetCoinsBalancesRequest
    {
        [JsonPropertyName("tet_address")]
        public string AddressTet { get; set; } = null!;
    }
}
