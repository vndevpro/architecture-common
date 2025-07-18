using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.Common.Tests.RandomStringTests
{
    [TestClass]
    public class NextValuesTests
    {
        [TestMethod]
        public void CanGetNextValuesAnyCharacters()
        {
            var generator = new RandomString(12, RandomString.Options.Any);

            int count = 0;

            foreach (var x in generator.NextValues(3))
            {
                count += 1;
                Assert.AreEqual(12, x.Length);
            }

            Assert.AreEqual(3, count);
        }
    }
}
