using System.Text.Json;
using Tectum.PublicBlockChainClient.Requests;
using Tectum.PublicBlockChainClient.Responses;
using Tectum.TectumLNodeClient.Requests;

namespace Tectum.PublicBlockChainClient
{
    public class PublicBlockChainClient : BaseHttpClient, IPublicBlockChainClient
    {
        public PublicBlockChainClient(HttpClient httpClient) : base(httpClient)
        {
        }

        public PublicBlockChainClient(HttpClient httpClient, JsonSerializerOptions jsonSerializerOptions) : base(httpClient,
            jsonSerializerOptions)
        {
        }

        public Task<GetCoinBalancesResponse?> GetCoinBalancesAsync(GetCoinsBalancesRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "address_tet", request.AddressTet }
            };
            return GetAsync<GetCoinBalancesResponse>("coins/balances", param, cancellationToken);
        }

        public Task<CreateCoinsTransferResponse?> CreateCoinTransferAsync(CreateCoinsTransferRequest request,
            CancellationToken cancellationToken = default)
        {
            return SendRequestAsync<CreateCoinsTransferResponse>("coins/transfer", HttpMethod.Post, request,
                cancellationToken);
        }

        public Task<CreateCoinsMigrateResponse?> CreateCoinMigrateAsync(CreateCoinsMigrateRequest request, CancellationToken cancellationToken = default)
        {
            return SendRequestAsync<CreateCoinsMigrateResponse>("coins/migrate", HttpMethod.Post, request, cancellationToken);
        }

        public Task<GetCoinsTransfersResponse?> GetCoinTransfersAsync(GetCoinsTransfersRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "rows", request.Rows.ToString() },
                { "skip", request.Skip.ToString() }
            };
            return GetAsync<GetCoinsTransfersResponse>("coins/transfers", param, cancellationToken);
        }

        public Task<GetCoinsTransfersResponse?> GetCoinTransfersUserAsync(GetCoinsTransfersUserRequest request,
            CancellationToken cancellationToken = default)
        {
            var param = new Dictionary<string, string>
            {
                { "rows", request.Rows.ToString() },
                { "skip", request.Skip.ToString() },
                { "session_key", request.SessionKey }
            };
            return GetAsync<GetCoinsTransfersResponse>("coins/transfers/user", param, cancellationToken);
        }

        public Task<GetCoinsTransferFeeResponse?> GetCoinTransferFeeAsync(CancellationToken cancellationToken = default)
        {
            return GetAsync<GetCoinsTransferFeeResponse>("coins/transfers/fee", new Dictionary<string, string>(),
                cancellationToken);
        }

        public Task<GetBlocksCountResponse?> GetBlocksCountAsync(CancellationToken cancellationToken = default)
        {
            return GetAsync<GetBlocksCountResponse>("blockscount", new Dictionary<string, string>(), cancellationToken);
        }


        public Task<KeyRecoverResponse?> KeyRecoverAsync(KeyRecoverRequest request,
            CancellationToken cancellationToken = default)
        {
            return SendRequestAsync<KeyRecoverResponse>("keys/recover", HttpMethod.Post, request,
                cancellationToken);
        }
    }
}