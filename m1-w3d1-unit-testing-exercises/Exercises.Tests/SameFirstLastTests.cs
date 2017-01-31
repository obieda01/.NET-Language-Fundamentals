using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;


namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        [TestMethod]
        public void SmartFirstLast_MethodTest()
        {
            Type type = typeof(SameFirstLast);
            MethodInfo method = type.GetMethod("IsItTheSame");
            MethodValidator.validateMethod(method, "IsItTheSame", typeof(bool));
        }


        [TestMethod]
        public void SmartFirstLast_IsItTheSameTests()
        {
            SameFirstLast testedinstance = new SameFirstLast();
            Assert.IsFalse(testedinstance.IsItTheSame(new int[] { }));
            Assert.IsTrue(testedinstance.IsItTheSame(new int[] {1,0,1 }));
            Assert.IsFalse(testedinstance.IsItTheSame(new int[] { 2, 0, 1 }));
            Assert.IsTrue(testedinstance.IsItTheSame(new int[] { -1, 5,54,3,4,2,5,6,4,0, -1 }));

        }
    }

}
