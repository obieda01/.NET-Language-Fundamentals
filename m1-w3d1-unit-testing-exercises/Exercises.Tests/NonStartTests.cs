using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]
        public void NonStart_MethodTest()
        {
            Type type = typeof(NonStart);
            MethodInfo method = type.GetMethod("GetPartialString");
            MethodValidator.validateMethod(method, "GetPartialString", typeof(string));

        }

        [TestMethod]
        public void NonStart_GetPartialSteringTest()
        {
            NonStart testedInstance = new NonStart();

            Assert.AreEqual("fd", testedInstance.GetPartialString("af", "ad"));
            Assert.AreEqual("27", testedInstance.GetPartialString("12", "67"));
            Assert.AreEqual("mksmdkasmksdmksdmhmksmdkasmksdmksdm", testedInstance.GetPartialString("amksmdkasmksdmksdmh", "amksmdkasmksdmksdm"));
            Assert.AreEqual("7", testedInstance.GetPartialString("", "67"));
            Assert.AreEqual("2", testedInstance.GetPartialString("12", ""));

        }
    }
}
