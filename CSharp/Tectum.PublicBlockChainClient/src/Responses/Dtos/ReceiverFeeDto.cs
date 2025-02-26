using System.Text.Json.Serialization;

namespace Tectum.PublicBlockChainClient.Responses.Dtos;

/// <summary>
/// Information about receiver 
/// </summary>
public class ReceiverFeeDto
{
    /// <summary>
    /// Amount
    /// </summary>
    public long Amount { get; set; }

    /// <summary>
    /// Receiver amount
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// Sign of validation
    /// </summary>
    public string Sign { get; set; } = null!;
    
    /// <summary>
    /// Date of validation
    /// </summary>
    [JsonPropertyName("date")] 
    public long CreatedAt { get; set; }

}