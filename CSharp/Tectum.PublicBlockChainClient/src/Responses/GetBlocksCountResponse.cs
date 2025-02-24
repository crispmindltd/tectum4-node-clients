namespace Tectum.PublicBlockChainClient.Responses;

public sealed class GetBlocksCountResponse : BaseResponse
{
    /// <summary>
    /// Current count of blocks
    /// </summary>
    public long BlocksCount { get; set; }
}