
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        [TestMethod]
        public void RomanNumerals_calculateTests()
        {
            //    Dictionary<int, string> romanNambersDictionary = new Dictionary<int, string>
            //{ {0,"" },{1,"I"},{2,"II"},{3,"III"},{4,"IV"}, {5,"V" },{6,"VI"},{7,"VII"},{8,"VIII"}, {9,"IX"},//ones
            //  { 10,"X"},{20,"XX"},{30,"XXX"},{40,"XL"},{50,"L" },{60,"LX" },{70,"LXX" },{80,"LXXX" },{90,"XC"},//tens
            //  { 100,"C"},{ 200,"CC"},{ 300,"CCC"},{400,"CD"} ,{500,"D"},{600,"DC"},{700,"DCC"},{800,"DCCC"},{900,"CM" },//hundreds
            //  { 1000,"M" },{ 2000,"MM" },{ 3000,"MMM" },//thousands
            //};
            Assert.AreEqual("I", new KataRomanNumerals().calculateRomanNumerals(1));
            Assert.AreEqual("IV", new KataRomanNumerals().calculateRomanNumerals(4));
            Assert.AreEqual("IX", new KataRomanNumerals().calculateRomanNumerals(9));
            Assert.AreEqual("LXX", new KataRomanNumerals().calculateRomanNumerals(70));
            Assert.AreEqual("CM", new KataRomanNumerals().calculateRomanNumerals(900));
            Assert.AreEqual("MM", new KataRomanNumerals().calculateRomanNumerals(2000));

            Assert.AreEqual("MMVIII", new KataRomanNumerals().calculateRomanNumerals(2008));

        }
    }
}
