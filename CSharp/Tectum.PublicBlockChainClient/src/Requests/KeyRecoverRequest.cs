using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Requests
{
    public class KeyRecoverRequest
    {
        [JsonPropertyName("seed_phrase")]
        public string SessionPhrase { get; set; } = null!;
    }
}