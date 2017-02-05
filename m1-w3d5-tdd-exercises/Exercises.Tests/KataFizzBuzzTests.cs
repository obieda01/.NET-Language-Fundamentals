using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {


        //## Kata Fizz Buzz

        //### Step 1

        //        Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz?".

        //Write tests that call a single method `FizzBuzz()`. Given a positive integer input n, return the FizzBuzz output as a string.

        //*Sample Output*
        //```
        //1 ->  returns "1"
        //2 -> returns "2"
        //3 -> returns "Fizz"
        //4 -> returns "4"
        //5 -> returns "Buzz" 
        //15 -> returns "FizzBuzz"
        //... etc up to 100
        //```

        //* Any number outside of the boundaries should return empty string -> ""

        //** Test Cases**

        //- What happens if 0 is passed in?
        //- What happens if 101 is passed in?
        //- What test cases can we come up with for the core FizzBuzz exercise?

        //[Link](http://codingdojo.org/cgi-bin/index.pl?KataFizzBuzz)

        [TestMethod]
        public void FizzBuzz_MultiplyTests()
        {
            Assert.AreEqual("1", new KataFizzBuzz().FizzBuzz(1));
            Assert.AreEqual("14", new KataFizzBuzz().FizzBuzz(14));
            Assert.AreEqual("89", new KataFizzBuzz().FizzBuzz(89));
            Assert.AreEqual("Fizz", new KataFizzBuzz().FizzBuzz(99));
            Assert.AreEqual("Buzz", new KataFizzBuzz().FizzBuzz(50));
            Assert.AreEqual("FizzBuzz", new KataFizzBuzz().FizzBuzz(15));
            Assert.AreEqual("FizzBuzz", new KataFizzBuzz().FizzBuzz(90));

            Assert.AreEqual("", new KataFizzBuzz().FizzBuzz(0));
            Assert.AreEqual("", new KataFizzBuzz().FizzBuzz(101));
            Assert.AreEqual("Buzz", new KataFizzBuzz().FizzBuzz(100));
            Assert.AreEqual("Buzz", new KataFizzBuzz().FizzBuzz(100));

        }


        //### Step 2

        //- A number is fizz if it is divisible by 3 or it has a 3 in it
        //- A number is buzz if it is divisible by 5 or it has a 5 in it


        [TestMethod]
        public void FizzBuzz_DivisableTests()
        {
            Assert.AreEqual("1", new KataFizzBuzz().FizzBuzzDivisable(1));
            Assert.AreEqual("14", new KataFizzBuzz().FizzBuzzDivisable(14));
            Assert.AreEqual("89", new KataFizzBuzz().FizzBuzzDivisable(89));
            Assert.AreEqual("Fizz", new KataFizzBuzz().FizzBuzzDivisable(99));
            Assert.AreEqual("Buzz", new KataFizzBuzz().FizzBuzzDivisable(50));
            Assert.AreEqual("FizzBuzz", new KataFizzBuzz().FizzBuzzDivisable(15));
            Assert.AreEqual("FizzBuzz", new KataFizzBuzz().FizzBuzzDivisable(90));

            Assert.AreEqual("", new KataFizzBuzz().FizzBuzzDivisable(0));
            Assert.AreEqual("", new KataFizzBuzz().FizzBuzzDivisable(101));
            Assert.AreEqual("Buzz", new KataFizzBuzz().FizzBuzzDivisable(100));
            Assert.AreEqual("Buzz", new KataFizzBuzz().FizzBuzzDivisable(100));

            Assert.AreEqual("Buzz", new KataFizzBuzz().FizzBuzzDivisable(52));
            Assert.AreEqual("Fizz", new KataFizzBuzz().FizzBuzzDivisable(13));
            Assert.AreEqual("FizzBuzz", new KataFizzBuzz().FizzBuzzDivisable(53));
            Assert.AreEqual("Fizz", new KataFizzBuzz().FizzBuzzDivisable(32));


        }
    }
}
