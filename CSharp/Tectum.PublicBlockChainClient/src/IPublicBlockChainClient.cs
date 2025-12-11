using Tectum.PublicBlockChainClient.Requests;
using Tectum.PublicBlockChainClient.Responses;

namespace Tectum.PublicBlockChainClient;

/// <summary>
/// Interface of methods to access to Tectum light node
/// </summary>
public interface IPublicBlockChainClient
{
    #region /coins

    /// <summary>
    /// Retrieve balances for multiple tokens: GET /coins/balance/byaddress
    /// </summary>
    /// <param name="request">Data of coin address</param>
    /// <param name="cancellationToken"></param>
    /// <returns>All tokens balances for current address</returns>
    Task<GetCoinBalancesResponse?> GetCoinBalancesAsync(
        GetCoinsBalancesRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Create transaction of TET coin: POST /coins/transfer
    /// </summary>
    /// <param name="request">Data of transaction</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Hash of success transaction</returns>
    Task<CreateCoinsTransferResponse?> CoinTransferAsync(
        CreateCoinsTransferRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Create migrate transaction of TET coin: POST /coins/migrate
    /// When using this transaction you need undestend one of member transaction
    /// will be owner of coin
    /// </summary>
    /// <param name="request">Data of transaction</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Hash of success transaction</returns>
    Task<CreateCoinsMigrateResponse?> CreateCoinMigrateAsync(
        CreateCoinsMigrateRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of transactions of TET coin: GET /coins/transfers
    /// </summary>
    /// <param name="request">Filter options</param>
    /// <param name="cancellationToken"></param>
    /// <returns>List of transactions</returns>
    Task<GetCoinsTransfersResponse?> GetCoinTransfersAsync(
        GetCoinsTransfersRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get full information of transaction: GET /coins/transfer?id={id}
    /// </summary>
    /// <param name="id">Number transaction</param>
    /// <param name="cancellationToken"></param>
    /// <returns>List of transactions</returns>
    Task<GetCoinTransferResponse?> GetCoinTransferAsync(
        long id,
        CancellationToken cancellationToken = default);


    /// <summary>
    /// Get list of transactions of TET coin: GET /coins/transfers/user
    /// </summary>
    /// <param name="request">Filter options</param>
    /// <param name="cancellationToken"></param>
    /// <returns>List of transactions</returns>
    Task<GetCoinsTransfersResponse?> GetCoinTransfersUserAsync(
        GetCoinsTransfersUserRequest request,
        CancellationToken cancellationToken = default);


    /// <summary>
    /// Generating a signed transaction
    /// POST /coins/transfer/create-sign
    /// </summary>
    /// <param name="request">Data of transaction</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Sign transaction</returns>
    public Task<CreateCoinsSingResonse> CreateCoinsSingAsync(CreateCoinsSingRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sending a signed transaction to the network
    /// POST /coins/transfer/sign
    /// </summary>
    /// <param name="request">Data of sign transaction</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Hash transaction</returns>
    public Task<SendCoinsSingResonse> SendCoinsSingAsync(SendCoinsSingRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Staking TET to become a network validator
    /// POST /coins/stake
    /// </summary>
    /// <param name="request">Data of stake transaction</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Hash transaction</returns>
    public Task<CoinsStakeResonse> SendCoinsStakeAsync(CoinsStakeRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Withdrawal of funds from staking
    /// POST /coins/unstake
    /// </summary>
    /// <param name="request">Data of unstake transaction</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Hash transaction</returns>
    public Task<CoinsUnStakeResonse> SendCoinsUnStakeAsync(CoinsUnStakeRequest request, CancellationToken cancellationToken = default);

    #endregion

    #region tokens
    
    /// <summary>
    /// Creating a new token
    /// POST /token/mint
    /// </summary>
    /// <param name="request">Information about token</param>
    /// <param name="cancellationToken"></param>
    /// <returns>New token information</returns>
    public Task<TokenMintResonse> TokenMintAsync(TokenMintRequest request, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Transfer tokens between two cryptocurrency addresses
    /// POST /token/transfer
    /// </summary>
    /// <param name="request">Create token transfer</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Hash transaction</returns>
    public Task<TokenTransferResonse> TokenTransferAsync(TokenTransferRequest request, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Get the token balance by the cryptocurrency address
    /// GET /token/balance/byaddress
    /// </summary>
    /// <param name="address">Address</param>
    /// <param name="cancellationToken"></param>
    /// <returns>How money tokens on address</returns>
    public Task<GetTokenBalanceAddressResponse> GetTokenBalanceByAddressAsync(string address, CancellationToken cancellationToken = default);

    /// <summary>
    /// Getting token information by ticker
    /// GET /token/info
    /// </summary>
    /// <param name="ticker">Token ticker</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Full information about token</returns>
    public Task<GetTokenInfoResponse> GetTokenInfoAsync(string ticker, CancellationToken cancellationToken = default);
    
    #endregion
    
    #region block

    /// <summary>
    /// Get count of blocks into blockchain: GET /blockscount
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>Number of blocks</returns>
    Task<GetBlocksCountResponse?> GetBlocksCountAsync(CancellationToken cancellationToken = default);

    #endregion
}