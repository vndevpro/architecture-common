using GdNet.Common.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.Common.Tests
{
    [TestClass]
    public class EmailMaskerTests
    {
        [TestMethod]
        public void CanMask()
        {
            var input = "myemail1@devcovery.com";
            var masker = new EmailMasker();

            var result = masker.Mask(input);

            Assert.AreEqual("my****l1@devcovery.com", result);
        }

        [TestMethod]
        public void CanMask2()
        {
            var input = "myemail01@devcovery.com";
            var masker = new EmailMasker();

            var result = masker.Mask(input);

            Assert.AreEqual("my*****01@devcovery.com", result);
        }
    }
}