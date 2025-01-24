using System.Text.Json.Serialization;

namespace Tectum.PublicBlockChainClient.Requests;

/// <summary>
/// Create coin
/// </summary>
public sealed class CreateCoinsTransferRequest
{
    public CreateCoinsTransferRequest(string fromAddress, string toAddress, long amount, string privateKey)
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