using System.Text.Json.Serialization;

namespace Tectum.PublicBlockChainClient.Requests;

/// <summary>
/// Create migrate transaction
/// </summary>
public class CreateCoinsMigrateRequest
{
    public CreateCoinsMigrateRequest(string fromAddress, string toAddress, long amount, string privateKey)
    {
        FromAddress = fromAddress;
        ToAddress = toAddress;
        Amount = amount;
        PrivateKey = privateKey;
    }
    
    [JsonPropertyName("from")] 
    public string FromAddress { get; }

    /// <summary>
    /// Address reciever
    /// </summary>
    [JsonPropertyName("to")]
    public string ToAddress { get; }

    /// <summary>
    /// Transaction amount
    /// </summary>
    [JsonPropertyName("amount")]
    public long Amount { get; }
    
    /// <summary>
    /// Address reciever
    /// </summary>
    [JsonPropertyName("private_key")]
    public string PrivateKey { get; }
}