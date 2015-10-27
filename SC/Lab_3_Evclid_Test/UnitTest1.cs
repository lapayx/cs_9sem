using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3_Evclid;

namespace Lab_3_Evclid_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Evclid1()
        {
            int res = Evclid.Calculate(25, 10);
            Assert.AreEqual(res, 5);
        }

        [TestMethod]
        public void Evclid2()
        {
            int res = Evclid.Calculate(25, 10,165,1895);
            Assert.AreEqual(res, 5);
        }
        [TestMethod]
        public void Evclid3()
        {
            long time = 0;
            int res = Evclid.CalculateBinaryFromTime(25, 185, out time);
            Assert.AreEqual(res, 5);
        }
        [TestMethod]
        public void Evclid4()
        {
            long time = 0;
            int res = Evclid.CalculateFromTime(25, 185, out time);
            Assert.AreEqual(res, 5);
        }
    }
}
