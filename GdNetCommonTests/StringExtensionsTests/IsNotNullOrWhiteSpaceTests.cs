using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.Common.Tests
{
    [TestClass]
    public class IsNotNullOrWhiteSpaceTests
    {
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
