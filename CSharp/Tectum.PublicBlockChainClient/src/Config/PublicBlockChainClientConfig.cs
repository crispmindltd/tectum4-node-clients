﻿namespace Tectum.PublicBlockChainClient.Config;

/// <summary>
/// Configuration of connection to lite node
/// </summary>
public sealed class PublicBlockChainClientConfig
{
    /// <summary>
    /// Base url to Tectum lite node
    /// </summary>
    public string BaseUrl { get; set; } = null!;
}