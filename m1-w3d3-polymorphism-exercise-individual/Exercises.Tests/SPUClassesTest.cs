using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;    
namespace Exercises.Tests
{
    [TestClass]
    public class SPUClassesTest
    {
        [TestMethod]
        public void SPU_4day_CalculateTestMethod1()
        {
            Assert.AreEqual(Math.Round((0 * 0.005 / 16) * 10, 2),new  _4_day().calculateRate(10,0));
            Assert.AreEqual(Math.Round((1 * 0.005 / 16) * 10, 2), new _4_day().calculateRate(10, 1));
            Assert.AreEqual(Math.Round((1000 * 0.005 / 16) * 1000, 2), new _4_day().calculateRate(1000, 1000));



        }
        [TestMethod]
        public void SPU_2day_CalculateTestMethod1()
        {
            Assert.AreEqual(Math.Round((0* 0.05 / 16) * 10, 2), new _2_day().calculateRate(10, 0));
            Assert.AreEqual(Math.Round((1 * 0.05 / 16) * 10, 2), new _2_day().calculateRate(10, 1));
            Assert.AreEqual(Math.Round((1000 * 0.05 / 16) * 10, 2), new _2_day().calculateRate(10, 1000));
            
        }

        [TestMethod]
        public void SPU_Nextday_CalculateTestMethod1()
        {
            Assert.AreEqual(Math.Round((0 * 0.05 / 16) * 10, 2), new Next_Day().calculateRate(10, 0));
            Assert.AreEqual(Math.Round((1 * 0.075 / 16) * 10, 2), new Next_Day().calculateRate(10, 1));
            Assert.AreEqual(Math.Round((1000 * 0.075 / 16) * 10, 2), new Next_Day().calculateRate(10, 1000));

        }
    }
}
