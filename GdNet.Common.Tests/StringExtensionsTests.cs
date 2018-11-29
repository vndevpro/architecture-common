using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.Common.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void ToVietnameseNoSign()
        {
            var input = "Không Đâu";
            
            var result = input.ToVietnameseNoSign();

            Assert.AreEqual("Khong Dau", result);
        }
    }
}
