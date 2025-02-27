﻿namespace Tectum.PublicBlockChainClient.Requests;

public class GetKeyPublicSessionKeyRequest
{
    /// <summary>
    /// Session key of connection 
    /// </summary>
    public string SessionKey { get; set; } = null!;
}