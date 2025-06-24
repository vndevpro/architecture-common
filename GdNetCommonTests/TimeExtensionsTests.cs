using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.Common.Tests
{
    [TestClass]
    public class TimeExtensionsTests
    {
        [TestMethod]
        public void ToNumber()
        {
            var time = new TimeSpan(1, 20, 10, 21);

            var timeInt = time.ToNumber();

            Assert.AreEqual(1201021, timeInt);
        }
    }
}