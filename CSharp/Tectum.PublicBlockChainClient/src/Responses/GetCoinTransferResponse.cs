using System.Text.Json.Serialization;
using Tectum.PublicBlockChainClient.Responses.Dtos;

namespace Tectum.PublicBlockChainClient.Responses;

/// <summary>
/// Response of information one transaction
/// </summary>
public sealed class GetCoinTransferResponse : BaseResponse
{
    /// <summary>
    /// Transaction hash
    /// </summary>
    public string Hash { get; set; } = null!;
    
    /// <summary>
    /// Transaction hash
    /// </summary>
    [JsonPropertyName("prev_hash")] 
    public string PreviousHash { get; set; } = null!;
    
    /// <summary>
    /// Number of block in chain
    /// </summary>
    public long Block { get; set; }
    
    /// <summary>
    /// Sign transaction
    /// </summary>
    public string Sign { get; set; }= null!;
    
    /// <summary>
    /// Id token, default 0 is TET
    /// </summary>
    [JsonPropertyName("token_id")] 
    public int TokenId { get; set; }
    
    /// <summary>
    /// Date create 
    /// </summary>
    [JsonPropertyName("date")] 
    public long CreatedAt { get; set; }

    /// <summary>
    /// Address sender money
    /// </summary>
    [JsonPropertyName("sender_address")] 
    public string AddressFrom { get; set; } = null!;
    
    /// <summary>
    /// Public key of sender money
    /// </summary>
    [JsonPropertyName("sender_pubkey")] 
    public string PublicKey { get; set; } = null!;
    
    
    /// <summary>
    /// Address receiver money
    /// </summary>
    [JsonPropertyName("receiver_address")]
    public string AddressTo { get; set; }= null!;
    
    /// <summary>
    /// Amount of transaction
    /// Need delete /100_000_000
    /// </summary>
    public long Amount { get; set; }
    
    /// <summary>
    /// Fee of transaction
    /// Need delete /100_000_000
    /// </summary>
    public long Fee { get; set; }
    
    /// <summary>
    /// Reward of transaction
    /// </summary>
    public RewardsDto? Rewards { get; set; } 
}