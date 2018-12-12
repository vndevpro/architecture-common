namespace GdNet.Common.Services
{
    /// <summary>
    /// Masking the email address to not readable string to avoid spammer taking the email
    /// </summary>
    public class EmailMasker
    {
        /// <summary>
        /// Masking a given email address
        /// </summary>
        public string Mask(string emailAddress)
        {
            return Mask(emailAddress, new DefaultEmailMaskingWorker());
        }

        /// <summary>
        /// Masking a given email address
        /// </summary>
        public string Mask(string emailAddress, IEmailMaskingWorker maskingWorker)
        {
            return maskingWorker.Mask(emailAddress);
        }
    }
}