using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEndTests
    {

        [TestMethod]
        public void MaxEnd_GetHerdTests()
        {
            MaxEnd3 testedInstance = new MaxEnd3();

            Assert.IsNotNull(testedInstance);
            
            CollectionAssert.AreEqual(new int[] {2,2,2}, testedInstance.MakeArray(new int[] {0,3,2}));
            CollectionAssert.AreNotEqual(new int[] {10,10}, testedInstance.MakeArray(new int[] {1,4,10}));
            CollectionAssert.AreEqual(new int[] { -5,-5,-5 }, testedInstance.MakeArray(new int[] { -5, 3, -6 }));
            CollectionAssert.AreEqual(new int[] {10, 10, 10 }, testedInstance.MakeArray(new int[] { 1, 4, 10 }));


        }


        [TestMethod]
        public void MaxEnd_MethodTest()
        {
            Type type = typeof(MaxEnd3);
            MethodInfo method = type.GetMethod("MakeArray");
            MethodValidator.validateMethod(method, "MakeArray", typeof(int[]));
        }
    }
}
    