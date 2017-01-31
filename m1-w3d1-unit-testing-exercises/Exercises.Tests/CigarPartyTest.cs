using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        public void CigarParty_HavePartyTests()
        {
            CigarParty testedInstance = new CigarParty();

            Assert.IsNotNull(testedInstance);
            Assert.AreEqual(false, testedInstance.HaveParty(30,false));
            Assert.AreEqual(true, testedInstance.HaveParty(50 , false));
            Assert.AreEqual(true, testedInstance.HaveParty(70, true));
            Assert.IsFalse(testedInstance.HaveParty(30, false));


        }

        [TestMethod]
        public void CigarParty_HasRequiredMethods()
        {
            Type type = typeof(CigarParty);
            MethodInfo method = type.GetMethod("HaveParty");
            MethodValidator.validateMethod(method, "haveParty", typeof(bool));
            
        }
    }
}
