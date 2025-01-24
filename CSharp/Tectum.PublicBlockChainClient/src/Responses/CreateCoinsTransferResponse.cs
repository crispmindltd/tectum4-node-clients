using System.Text.Json.Serialization;

namespace Tectum.PublicBlockChainClient.Responses;

/// <summary>
/// Created transaction
/// </summary>
public sealed class CreateCoinsTransferResponse : BaseResponse
{
    [JsonPropertyName("hash")] 
    public string? Hash { get; set; }
}