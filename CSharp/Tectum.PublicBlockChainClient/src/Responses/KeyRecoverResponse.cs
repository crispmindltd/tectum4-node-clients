using System.Text.Json.Serialization;

namespace Tectum.PublicBlockChainClient.Responses;

public class KeyRecoverResponse : BaseResponse
{
    [JsonPropertyName("private_key")]
    public string? PrivateKey { get; set; }

    [JsonPropertyName("public_key")]
    public string? PublicKey { get; set; } 
}