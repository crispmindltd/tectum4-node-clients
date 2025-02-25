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
    Task<CreateCoinsTransferResponse?> CreateCoinTransferAsync(
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
    /// Get full information of transaction: GET /coins/transfers/{id}
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
    /// Get transaction fee of TET coin: GET /coins/transfers/fee
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>Fee of transaction</returns>
    Task<GetCoinsTransferFeeResponse?> GetCoinTransferFeeAsync(
        CancellationToken cancellationToken = default);

    #endregion
}