namespace GdNet.Common.Services
{
    /// <summary>
    /// Encrypt and decrypt a string
    /// </summary>
    public class StringEncryptor
    {
        /// <summary>
        /// Encrypt a string with default worker
        /// </summary>
        public string Encrypt(string plainText, string passPhrase)
        {
            return Encrypt(plainText, passPhrase, new DefaultStringEncryptionWorker());
        }

        /// <summary>
        /// Encrypt a string
        /// </summary>
        public string Encrypt(string plainText, string passPhrase, IStringEncryptionWorker encryptionWorker)
        {
            return encryptionWorker.Encrypt(plainText, passPhrase);
        }

        /// <summary>
        /// Decrypt a string with default worker
        /// </summary>
        public string Decrypt(string plainText, string passPhrase)
        {
            return Decrypt(plainText, passPhrase, new DefaultStringEncryptionWorker());
        }

        /// <summary>
        /// Decrypt a string
        /// </summary>
        public string Decrypt(string plainText, string passPhrase, IStringEncryptionWorker encryptionWorker)
        {
            return encryptionWorker.Decrypt(plainText, passPhrase);
        }
    }
}