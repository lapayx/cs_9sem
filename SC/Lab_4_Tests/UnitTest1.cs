using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_4_triangle;

namespace Lab_4_Tests
{
    [TestClass]
    public class UnitTest1
    {
        Triangle t,z;
        public UnitTest1()
        {
            t = new Triangle(10, 11, 5);
            z = new Triangle(10, 5,15);

        }

        [TestMethod]
        public void Triangle1()
        {

            Assert.AreEqual(true, t.isExists());

        }
        [TestMethod]
        public void Triangle2()
        {

            Assert.AreEqual(false, z.isExists());

        }
        [TestMethod]
        public void Triangle3()
        {

            Assert.AreEqual( 26, t.Perim());

        }
    }
}
