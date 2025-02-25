using System.Text.Json.Serialization;

namespace Tectum.PublicBlockChainClient.Responses.Dtos;

/// <summary>
/// Infroramtion about one reward of Archiver or Validator
/// </summary>
public class RewardDto
{
    public long Amount { get; set; } 
    public string Address { get; set; } = null!;
    public string Sign { get; set; } = null!;

    [JsonPropertyName("signer_pubkey")] 
    public string PublicKey { get; set; } = null!;

    [JsonPropertyName("started_date")] 
    public long StartedDate { get; set; }

    [JsonPropertyName("finished_date")] 
    public long FinishedDate { get; set; }
}