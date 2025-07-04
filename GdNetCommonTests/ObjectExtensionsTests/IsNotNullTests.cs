using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GdNet.Common.Tests.ObjectExtensionsTests
{
    [TestClass]
    public class IsNotNullTests
    {
        [TestMethod]
        public void ShouldReturnCorrectResultForNullObject()
        {
            object input = null;

            var result = input.IsNotNull();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldReturnCorrectResultForNullableObject()
        {
            Nullable<int> input = null;

            var result = input.IsNotNull();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldReturnCorrectResultForNullableObject2()
        {
            Nullable<int> input = 3;

            var result = input.IsNotNull();

            Assert.IsTrue(result);
        }
    }
}
