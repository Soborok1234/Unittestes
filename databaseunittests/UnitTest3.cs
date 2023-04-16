using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace databaseunittests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int slog = a + b;
            Assert.AreEqual(slog, c);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int d = 1;
            int e = 2;
            int f = 3;
            int slog2 = d + e;
            Assert.AreEqual(slog2, f);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int g = 1;
            int h = 2;
            int i = 3;
            int slog3 = g + h;
            Assert.AreEqual(slog3, i);
        }
    }
}
