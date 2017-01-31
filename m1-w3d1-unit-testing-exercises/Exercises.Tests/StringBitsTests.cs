using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        [TestMethod]
        public void StringBitsTests_MethodTest()
        {
            Type type = typeof(StringBits);
            MethodInfo method = type.GetMethod("GetBits");
            MethodValidator.validateMethod(method, "GetBits",typeof(string));               
        }

        [TestMethod]
        public void StringBitsTests_GetBitsTests()
        {
            StringBits testedInstance = new StringBits();
            string str = "amd";
            Assert.AreEqual(str, testedInstance.GetBits("ahmad"));
            Assert.AreEqual("", testedInstance.GetBits(""));
            Assert.AreNotEqual("", testedInstance.GetBits("ahmad"));
            Assert.AreEqual("amd", testedInstance.GetBits("ahmadt"));


        }
    }
}
