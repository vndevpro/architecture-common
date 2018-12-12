namespace GdNet.Common.Services
{
    /// <summary>
    /// Masking worker contract
    /// </summary>
    public interface IEmailMaskingWorker
    {
        /// <summary>
        /// Masking a given email address
        /// </summary>
        string Mask(string inputAddress);
    }
}