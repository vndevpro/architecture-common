using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.Common.Tests.RandomStringTests
{
    [TestClass]
    public class NextValueTests
    {
        [TestMethod]
        public void ShouldReturnCorrectNumbers()
        {
            var generator = new RandomString();

            var value = generator.NextValue();

            Assert.AreEqual(6, value.Length);
            foreach (var item in value)
            {
                Assert.IsTrue(int.Parse(item.ToString()) >= 0);
            }
        }

        [TestMethod]
        public void ShouldReturnCharactersInAnyType()
        {
            var generator = new RandomString(12, RandomString.Options.Any);

            var x = generator.NextValue();

            Assert.AreEqual(12, x.Length);
        }
    }
}
