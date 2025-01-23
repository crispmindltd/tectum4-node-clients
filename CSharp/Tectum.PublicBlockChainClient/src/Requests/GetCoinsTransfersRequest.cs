namespace Tectum.TectumLNodeClient.Requests
{
    /// <summary>
    /// Request get all transactions of coin TET
    /// </summary>
    public class GetCoinsTransfersRequest
    {
        /// <summary>
        /// How many rows need to send
        /// </summary>
        public int Rows { get; set; }
        
        /// <summary>
        /// How many rows need to skip
        /// </summary>
        public long Skip { get; set; }
    }
}