using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GdNet.Common.Tests.ObjectExtensionsTests
{
    [TestClass]
    public class IsNullTests
    {
        [TestMethod]
        public void ShouldReturnCorrectResultForNullObject()
        {
            object input = null;

            var result = input.IsNull();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnCorrectResultForNullableObject()
        {
            Nullable<int> input = null;

            var result = input.IsNull();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnCorrectResultForNullableObject2()
        {
            Nullable<int> input = 3;

            var result = input.IsNull();

            Assert.IsFalse(result);
        }
    }
}
