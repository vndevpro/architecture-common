using GdNet.Common.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.Common.Tests
{
    [TestClass]
    public class Base64SafeEncoderTests
    {
        [TestMethod]
        public void CanEncode()
        {
            var text = "GdNet.Common";
            var encoded = new Base64SafeEncoder().Encode(text);
            Assert.AreEqual("R2ROZXQuQ29tbW9u", encoded);
        }

        [TestMethod]
        public void CanDecode()
        {
            var encoded = "R2ROZXQuQ29tbW9u";
            var text = new Base64SafeEncoder().Decode(encoded);
            Assert.AreEqual("GdNet.Common", text);
        }
    }
}