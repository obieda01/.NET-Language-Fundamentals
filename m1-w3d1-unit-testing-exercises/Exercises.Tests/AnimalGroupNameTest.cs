using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {

        [TestMethod]
        public void AnimalGroupName_GetHerdTests()
        {
            AnimalGroupName testedInstance = new AnimalGroupName();

            Assert.IsNotNull(testedInstance);
            Assert.AreEqual("Crash", testedInstance.GetHerd("rhino"));
            Assert.AreNotEqual("unknown", testedInstance.GetHerd("rhino"));
            Assert.AreEqual("unknown", testedInstance.GetHerd("excel"));


        }


        [TestMethod]
        public void AnimalGroupName_MethodTest()
        {
            Type type = typeof(AnimalGroupName);
            MethodInfo method = type.GetMethod("GetHerd");
            MethodValidator.validateMethod(method, "GetHerd", typeof(string));           
        }
    }
}
