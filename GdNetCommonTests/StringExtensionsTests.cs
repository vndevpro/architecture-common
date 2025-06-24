using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.Common.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void ShouldTrimSafe()
        {
            string input = "  Hello World  ";
            string expected = "Hello World";

            string result = input.TrimSafe();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldTrimSafeForNull()
        {
            string input = null;
            string expected = null;

            string result = input.TrimSafe();

            Assert.AreEqual(expected, result);
        }

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

        [TestMethod]
        public void ShouldReturnCorrectResultForIsNotNullOrWhiteSpaceWhenNull()
        {
            string input = null;

            var result = input.IsNotNullOrWhiteSpace();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ShouldReturnCorrectResultForIsNotNullOrWhiteSpaceWhenEmpty()
        {
            string input = string.Empty;

            var result = input.IsNotNullOrWhiteSpace();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ShouldReturnCorrectResultForIsNotNullOrWhiteSpaceWhenWhiteSpace()
        {
            string input = " ";

            var result = input.IsNotNullOrWhiteSpace();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ShouldReturnCorrectResultForIsNotNullOrWhiteSpaceWhenNotWhiteSpace()
        {
            string input = " a";

            var result = input.IsNotNullOrWhiteSpace();

            Assert.AreEqual(true, result);
        }
    }
}
