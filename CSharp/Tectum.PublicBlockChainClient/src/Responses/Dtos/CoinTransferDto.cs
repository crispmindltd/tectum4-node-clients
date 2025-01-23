using System.Text.Json.Serialization;

namespace Tectum.PublicBlockChainClient.Responses.Dtos
{
    /// <summary>
    /// Dto transfer
    /// </summary>
    public class CoinTransferDto
    {
        /// <summary>
        /// Date transaction in unix time
        /// </summary>
        public long Date { get; set; }
        
        /// <summary>
        /// Number block in chain
        /// </summary>
        public long Block { get; set; }

        /// <summary>
        /// Address from money transferred
        /// </summary>
        [JsonPropertyName("address_from")] 
        public string AddressFrom { get; set; } = null!;

        /// <summary>
        /// Address to money transferred
        /// </summary>
        [JsonPropertyName("address_to")] 
        public string AddressTo { get; set; } = null!;

        /// <summary>
        /// Hash block
        /// </summary>
        [JsonPropertyName("hash")]
        public string Hash { get; set; } = null!;

        /// <summary>
        /// Amount of transferring
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Fee
        /// </summary>
        public decimal Fee { get; set; }
    }
}
