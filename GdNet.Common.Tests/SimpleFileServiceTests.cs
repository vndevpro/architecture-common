using GdNet.Common.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.Common.Tests
{
    [TestClass]
    public class SimpleFileServiceTests
    {
        [TestMethod]
        public void CanSaveFileWithComplexPath()
        {
            var service = new SimpleFileService(@"C:\Temp");
            var virtualPath = @"1\File1.txt";

            var ops = service.SaveFile(virtualPath, "Test");

            Assert.IsTrue(ops.Result);
        }
    }
}