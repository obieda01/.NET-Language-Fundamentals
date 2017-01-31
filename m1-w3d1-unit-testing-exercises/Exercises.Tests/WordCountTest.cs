using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Collections.Generic;
namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void WordCount_MethodTest()
        {
            Type type = typeof(WordCount);
            MethodInfo method = type.GetMethod("GetCount");
            MethodValidator.validateMethod(method, "GetCount", typeof(Dictionary<string, int>));
        }

        [TestMethod]
        public void WordCount_GetCountTests()
        {
            WordCount testedInstance = new WordCount();
            Dictionary<string, int> expected = new Dictionary<string, int>(){ { "ab", 1 } } ;
            string[] actual = { "ab" };
            CollectionAssert.AreEqual(expected, testedInstance.GetCount(actual));



             expected = new Dictionary<string, int>() { { "ab", 2 } };
            actual=new string[]{"ab","ab" };
            CollectionAssert.AreEqual(expected, testedInstance.GetCount(actual));


            expected = new Dictionary<string, int>() {  };
            actual = new string[] {  };
            CollectionAssert.AreEqual(expected, testedInstance.GetCount(actual));


            expected = new Dictionary<string, int>() { { "ab", 2 }, { "af",1}, {" ",1 } };
            actual = new string[] { "ab", "ab","af"," " };
            CollectionAssert.AreEqual(expected, testedInstance.GetCount(actual));
        }
    }
}
