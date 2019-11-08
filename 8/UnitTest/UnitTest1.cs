using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLib;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double R = 1;
            double S = Class1.Circle(R);
            Assert.AreEqual(S, Math.PI);
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            double x = 7, y = 3, z = 6;
            double S = Class1.Triagle(x, y, z);
            Assert.AreEqual(S, 8.94427190999916);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double x = 5, y = 3, z = 4;
            Assert.AreEqual(Class1.is90grace(x,y,z), true);
        }
    }
}
