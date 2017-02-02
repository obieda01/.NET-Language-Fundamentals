using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;
namespace Exercises.Tests
{
    [TestClass]
    public class _1stClassTest
    {
        [TestMethod]
        public void PostalService_FirstClass_calculateRateTests()
        {
            Assert.AreEqual(0, new _1stClass().calculateRate(10, 0));
            Assert.AreEqual(Math.Round(10*0.035,2), new _1stClass().calculateRate(10, 1));
            Assert.AreEqual(Math.Round(10 * 0.04, 2), new _1stClass().calculateRate(10, 8));
            Assert.AreEqual(Math.Round(10 * 0.047, 2), new _1stClass().calculateRate(10, 9));
            Assert.AreEqual(Math.Round(10 * 0.195, 2), new _1stClass().calculateRate(10, 16));
            Assert.AreEqual(Math.Round(10 * 0.45, 2), new _1stClass().calculateRate(10, 64));
            Assert.AreEqual(Math.Round(10 * 0.5, 2), new _1stClass().calculateRate(10, 200));


        }
        [TestMethod]
        public void PostalService_SecondClass_calculateRateTests()
        {
            Assert.AreEqual(0, new _2ndClass().calculateRate(10, 0));
            Assert.AreEqual(Math.Round(10 * 0.0035, 2), new _2ndClass().calculateRate(10, 1));
            Assert.AreEqual(Math.Round(10 * 0.004, 2), new _2ndClass().calculateRate(10, 8));
            Assert.AreEqual(Math.Round(10 * 0.0047, 2), new _2ndClass().calculateRate(10, 9));
            Assert.AreEqual(Math.Round(10 * 0.0195, 2), new _2ndClass().calculateRate(10, 16));
            Assert.AreEqual(Math.Round(10 * 0.045, 2), new _2ndClass().calculateRate(10, 64));
            Assert.AreEqual(Math.Round(10 * 0.05, 2), new _2ndClass().calculateRate(10, 200));


        }

        [TestMethod]
        public void PostalService_ThirdClass_calculateRateTests()
        {
            Assert.AreEqual(0, new _3rdClass().calculateRate(10, 0));
            Assert.AreEqual(Math.Round(10 * 0.002, 2), new _3rdClass().calculateRate(10, 1));
            Assert.AreEqual(Math.Round(10 * 0.0022, 2), new _3rdClass().calculateRate(10, 8));
            Assert.AreEqual(Math.Round(10 * 0.0024, 2), new _3rdClass().calculateRate(10, 9));
            Assert.AreEqual(Math.Round(10 * 0.015, 2), new _3rdClass().calculateRate(10, 16));
            Assert.AreEqual(Math.Round(10 * 0.016, 2), new _3rdClass().calculateRate(10, 64));
            Assert.AreEqual(Math.Round(10 * 0.017, 2), new _3rdClass().calculateRate(10, 200));


        }
    }
}
