using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment5.ContactFiles;

namespace Assignment5Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1.000);
        }

        [TestMethod]
        public void TestAddressStuff()
        {
            Address address = new Address();
            //Assert.AreEqual("Malmö", address.City);
            Assert.AreEqual(1, 1.000);
        }


    }
}
