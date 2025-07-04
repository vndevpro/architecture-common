using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.Common.Tests
{
    [TestClass]
    public class TrimSafeTests
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
    }
}
