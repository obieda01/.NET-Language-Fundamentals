using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string FizzBuzz(int number)
        {
            if (number <= 0 || number > 100) return "";
            if ((number % 3 == 0 && number % 5 == 0))
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0) return "Fizz";
            else if (number % 5 == 0) return "Buzz";
            else return number.ToString();
        }


        public string FizzBuzzDivisable(int number)
        {
            if (number <= 0 || number > 100) return "";
            if (number.ToString().Length == 1)
            {
                if ((number % 3 == 0 && number % 5 == 0))
                {
                    return "FizzBuzz";
                }
                else if (number % 3 == 0 || number.ToString()[0] == '3' ) return "Fizz";
                else if (number % 5 == 0 || number.ToString()[0] == '5' ) return "Buzz";
                else return number.ToString();
            }
            else
            {
                if ((number % 3 == 0 && number % 5 == 0) ||
                    (number.ToString()[0] == '3' && number.ToString()[1] == '5') ||
                    (number.ToString()[1] == '3' && number.ToString()[0] == '5'))
                {
                    return "FizzBuzz";
                }
                else if (number % 3 == 0 || number.ToString()[0] == '3' || number.ToString()[1] == '3') return "Fizz";
                else if (number % 5 == 0 || number.ToString()[0] == '5' || number.ToString()[1] == '5') return "Buzz";
                else return number.ToString();

            }
        }

    }
}
