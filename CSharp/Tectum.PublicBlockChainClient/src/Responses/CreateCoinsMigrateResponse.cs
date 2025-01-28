using System.Text.Json.Serialization;

namespace Tectum.PublicBlockChainClient.Responses;

/// <summary>
/// Created migrate transaction
/// </summary>
public sealed class CreateCoinsMigrateResponse: BaseResponse
{
    [JsonPropertyName("hash")] 
    public string? Hash { get; set; }
}