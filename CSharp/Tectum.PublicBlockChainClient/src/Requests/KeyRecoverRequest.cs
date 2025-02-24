using System.Text.Json.Serialization;

namespace Tectum.PublicBlockChainClient.Requests;

public class KeyRecoverRequest
{
    [JsonPropertyName("seed_phrase")]
    public string SessionPhrase { get; set; } = null!;
}