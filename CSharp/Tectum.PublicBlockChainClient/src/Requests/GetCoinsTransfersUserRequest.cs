using System.Text.Json.Serialization;

namespace Tectum.TectumLNodeClient.Requests
{
    public class GetCoinsTransfersUserRequest
    {
        /// <summary>
        /// How many rows need to send
        /// </summary>
        public int Rows { get; set; }

        /// <summary>
        /// How many rows need to skip
        /// </summary>
        public long Skip { get; set; }

        /// <summary>
        /// Session key
        /// </summary>
        [JsonPropertyName("session_key")]
        public string SessionKey { get; set; } = null!;
    }
}