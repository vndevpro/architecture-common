using System;
using System.Text;

namespace GdNet.Common.Services
{
    /// <summary>
    /// Masking email address by replacing 50% of characters by asterik
    /// </summary>
    public class DefaultEmailMaskingWorker : IEmailMaskingWorker
    {
        /// <summary>
        /// Replace 50% of characters by asterik(s). Eg myemail@devcovery.com will be my***il@devcovery.com
        /// </summary>
        public string Perform(string inputAddress)
        {
            var emailAddress = inputAddress.TrimSafe();
            var theAtIndex = emailAddress.IndexOf("@", StringComparison.InvariantCulture);
            if (theAtIndex < 1)
            {
                return emailAddress;
            }

            var numberOfAskteriks = (int)Math.Ceiling(theAtIndex / 2.0);
            var startIndex = (theAtIndex - numberOfAskteriks) / 2;

            var sb = new StringBuilder();
            sb.Append(emailAddress.Substring(0, startIndex));
            sb.Append(new string('*', numberOfAskteriks));
            sb.Append(emailAddress.Substring(startIndex + numberOfAskteriks));

            return sb.ToString();
        }
    }
}