namespace Tectum.PublicBlockChainClient.Responses.Dtos;

/// <summary>
/// Reward information
/// </summary>
public sealed class RewardsDto
{
    /// <summary>
    /// Amount of reward
    /// </summary>
    public long Amount { get; set; }

    /// <summary>
    /// Information about reward to Archiver
    /// </summary>
    public RewardDto? Archiver { get; set; }

    /// <summary>
    /// Information about rewards to all Validators
    /// </summary>
    public List<RewardDto>? Validators { get; set; }
}