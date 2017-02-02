using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
    [TestClass]
    public class FexEdTest
    {
        [TestMethod]
        public void FexEd_CalculateTest()
        {
            Assert.AreEqual(0, new FexEd().calculateRate(10, 0));
            Assert.AreEqual(20, new FexEd().calculateRate(500, 47));
            Assert.AreEqual(25, new FexEd().calculateRate(501, 47));
            Assert.AreEqual(20, new FexEd().calculateRate(500, 48));
            Assert.AreEqual(23, new FexEd().calculateRate(500, 49));

        }
    }
}
