using System.Collections.Generic;
using Tectum.PublicBlockChainClient.Responses.Dtos;

namespace Tectum.PublicBlockChainClient.Responses
{
    public class GetCoinsTransfersResponse : BaseResponse
    {
        public List<CoinTransferDto>? Transactions { get; set; }
    }
}