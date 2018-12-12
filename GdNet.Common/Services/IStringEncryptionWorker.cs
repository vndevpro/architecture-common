namespace GdNet.Common.Services
{
    /// <summary>
    /// Encrypt and decrypt a string
    /// </summary>
    public interface IStringEncryptionWorker
    {
        /// <summary>
        /// Encrypt a string
        /// </summary>
        string Encrypt(string plainText, string passPhrase);

        /// <summary>
        /// Decrypt a string
        /// </summary>
        string Decrypt(string cipherText, string passPhrase);
    }
}