using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Linq;

namespace GdNet.Common.Tests
{
    [TestClass]
    public class RandomStringTests
    {
        [TestMethod]
        public void CanGetNextValueNumbers()
        {
            var generator = new RandomString();

            var x = generator.NextValue();

            Assert.AreEqual(6, x.Length);

            x.ToCharArray().ToList().ForEach(c =>
            {
                int num;
                if (!int.TryParse(c.ToString(CultureInfo.InvariantCulture), out num))
                {
                    Assert.Fail("Must contain only number characters");
                }
            });
        }

        [TestMethod]
        public void CanGetNextValueAny()
        {
            var generator = new RandomString(12, RandomString.Options.Any);

            var x = generator.NextValue();

            Assert.AreEqual(12, x.Length);
        }
    }
}