using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pryam;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPlo()
        {
            int s = Program.Plo(2, 5);

            Assert.AreEqual<int>(10, s);


        }

        [TestMethod]
        public void TestPlo0()
        {

            int s = Program.Plo(5, 5);

            Assert.AreEqual<int>(25, s);


        }

        [TestMethod]
        public void TestPlo1()
        {

            int s = Program.Plo(7, 3);

            Assert.AreEqual<int>(21, s);


        }

        [TestMethod]
        public void TestPlo2()
        {

            int s = Program.Plo(8, 8);

            Assert.AreEqual<int>(64, s);


        }

        [TestMethod]
        public void TestPlo3()
        {

            int s = Program.Plo(9, 3);

            Assert.AreEqual<int>(27, s);


        }

        [TestMethod]
        public void TestPlo4()
        {

            int s = Program.Plo(25, 4);

            Assert.AreEqual<int>(100, s);


        }

        [TestMethod]
        public void TestPlo5()
        {

            int s = Program.Plo(3, 4);

            Assert.AreEqual<int>(12, s);

        }
    }
}
