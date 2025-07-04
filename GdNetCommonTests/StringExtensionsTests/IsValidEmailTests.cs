using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.Common.Tests.StringExtensionsTests
{
    [TestClass]
    public class IsValidEmailTests
    {
        [TestMethod]
        public void CanCheckValidEmail()
        {
            string input = "test@yameo.com";

            var result = input.IsValidEmail();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CanCheckInvalidEmail()
        {
            string input = "test@yameo";

            var result = input.IsValidEmail();

            Assert.AreEqual(false, result);
        }
    }
}
