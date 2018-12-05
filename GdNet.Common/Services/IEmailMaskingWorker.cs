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
        /// <param name="inputAddress"></param>
        /// <returns></returns>
        string Perform(string inputAddress);
    }
}