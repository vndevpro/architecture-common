namespace GdNet.Common.Services
{
    /// <summary>
    /// Encrypt and decrypt a string
    /// </summary>
    public class DefaultStringEncryptionWorker : IStringEncryptionWorker
    {
        public string Encrypt(string plainText, string passPhrase)
        {
            return StringCipher.Encrypt(plainText, passPhrase);
        }

        public string Decrypt(string cipherText, string passPhrase)
        {
            return StringCipher.Decrypt(cipherText, passPhrase);
        }
    }
}