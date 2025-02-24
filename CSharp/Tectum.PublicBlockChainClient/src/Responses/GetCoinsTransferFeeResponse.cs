namespace Tectum.PublicBlockChainClient.Responses;

public sealed class GetCoinsTransferFeeResponse : BaseResponse
{
    /// <summary>
    /// Amount of fee
    /// </summary>
    public decimal Fee { get; set; }
}