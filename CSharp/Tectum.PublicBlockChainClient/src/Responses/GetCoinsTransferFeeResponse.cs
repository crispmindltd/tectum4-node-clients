namespace Tectum.PublicBlockChainClient.Responses
{
    public class GetCoinsTransferFeeResponse : BaseResponse
    {
        /// <summary>
        /// Amount of fee
        /// </summary>
        public decimal Fee { get; set; }
    }
}