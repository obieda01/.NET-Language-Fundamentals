using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Exercises.Tests
{
    [TestClass]
    public class MethodValidator
    {
        [TestMethod]
        public static void validateMethod(MethodInfo method,string name,Type returntybe)
        {
            Assert.AreEqual(returntybe, method.ReturnType);
            Assert.AreEqual(true, method.IsPublic);
        }
    }
}
