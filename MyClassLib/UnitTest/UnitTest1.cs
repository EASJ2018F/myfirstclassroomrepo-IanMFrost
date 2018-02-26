using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLib;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlusMetode()
        {
            // arrange 
           Calculator lommeregner = new Calculator();
            // act 
            lommeregner.Addition(2, 5);
            double expectedValue = 7;
            // assert
            Assert.AreEqual(expectedValue,lommeregner.Addition(2,5));

        }

        [TestMethod]
        public void MinusMetode()
        {
            Calculator lommeregner2 = new Calculator();
            double expectedValue = 8;
            Assert.AreEqual(expectedValue,lommeregner2.Substraction(10,2));
        }

        [TestMethod]
        public void GangeMetode()
        {
            Calculator lommeregner3 = new Calculator();
            double expectedValue = 4;
            Assert.AreEqual(expectedValue, lommeregner3.Multiplication(2,2));
        }

        [TestMethod]
        public void DividerMetode()
        {
            Calculator lommeregner4 = new Calculator();
            double expected = 10;
            Assert.AreEqual(expected,lommeregner4.Division(100,10));
        }
    }
}
