using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.Common.Tests
{
    [TestClass]
    public class IsNotNullOrEmptyTests
    {
        [TestMethod]
        public void ShouldReturnCorrectResultForIsNotNullOrEmptyWhenNull()
        {
            string input = null;

            var result = input.IsNotNullOrEmpty();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ShouldReturnCorrectResultForIsNotNullOrEmptyWhenEmpty()
        {
            string input = string.Empty;

            var result = input.IsNotNullOrEmpty();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ShouldReturnCorrectResultForIsNotNullOrEmptyWhenNotEmpty()
        {
            string input = " ";

            var result = input.IsNotNullOrEmpty();

            Assert.AreEqual(true, result);
        }
    }
}
