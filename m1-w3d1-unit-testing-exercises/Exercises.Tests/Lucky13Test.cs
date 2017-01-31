using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {

        [TestMethod]
        public void Lucky13_HasReuiredMethods()
        {
            Type type = typeof(Lucky13);
            Lucky13 Lucky13 = (Lucky13)Activator.CreateInstance(type);

            MethodInfo method = type.GetMethod("GetLucky");
            MethodValidator.validateMethod(method, "GetLucky", typeof(bool));           
            

        }



        [TestMethod]
        public void Lucky13_GetCountTests()
            {
            Assert.IsNotNull(new Lucky13());
            Lucky13 testedInstasnce = new Lucky13();
            Assert.IsTrue(testedInstasnce.GetLucky(new int[] { }));
            Assert.IsFalse(testedInstasnce.GetLucky(new int[] {1 }));
            Assert.IsFalse(testedInstasnce.GetLucky(new int[] { 3 }));
            Assert.IsFalse(testedInstasnce.GetLucky(new int[] { 1,3 }));
            Assert.IsFalse(testedInstasnce.GetLucky(new int[] {0,1 }));
            Assert.IsFalse(testedInstasnce.GetLucky(new int[] {0,3}));
            Assert.IsTrue(testedInstasnce.GetLucky(new int[] {0 }));
            Assert.IsTrue(testedInstasnce.GetLucky(new int[] { 0,4,5,6,7 }));
           
        }
    }
}
