using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {
        Dictionary<int, string> romanNambersDictionary = new Dictionary<int, string>
        { {0,"" },{1,"I"},{2,"II"},{3,"III"},{4,"IV"}, {5,"V" },{6,"VI"},{7,"VII"},{8,"VIII"}, {9,"IX"},//ones
          { 10,"X"},{20,"XX"},{30,"XXX"},{40,"XL"},{50,"L" },{60,"LX" },{70,"LXX" },{80,"LXXX" },{90,"XC"},//tens
          { 100,"C"},{ 200,"CC"},{ 300,"CCC"},{400,"CD"} ,{500,"D"},{600,"DC"},{700,"DCC"},{800,"DCCC"},{900,"CM" },//hundreds
          { 1000,"M" },{ 2000,"MM" },{ 3000,"MMM" },//thousands
        };
        StringBuilder result = new StringBuilder();

        public string calculateRomanNumerals(int number)
        {
            if (number <= 0 || number > 3000) return string.Empty;
            string stringNumber = number.ToString();
            int numberLength = stringNumber.Length;
           
                if (numberLength == 4)
                {
                    result.Append(romanNambersDictionary[int.Parse(stringNumber.Substring(0,1))* 1000]);
                    result.Append(romanNambersDictionary[int.Parse(stringNumber.Substring(1, 1))*100]);
                    result.Append(romanNambersDictionary[int.Parse(stringNumber.Substring(2, 1)) *10]);
                    result.Append(romanNambersDictionary[int.Parse(stringNumber.Substring(3))]);

                }

                if (numberLength == 3)
                {
                    result.Append(romanNambersDictionary[int.Parse(stringNumber.Substring(0, 1)) * 100]);
                    result.Append(romanNambersDictionary[int.Parse(stringNumber.Substring(1, 1)) * 10]);
                    result.Append(romanNambersDictionary[int.Parse(stringNumber.Substring(2))]);
                }
                if (numberLength == 2)
                {
                    result.Append(romanNambersDictionary[int.Parse(stringNumber.Substring(0, 1)) * 10]);
                    result.Append(romanNambersDictionary[int.Parse(stringNumber.Substring(1))]);
                }
                if (numberLength == 1)
                {
                    result.Append(romanNambersDictionary[int.Parse(stringNumber)]);

                
            }
            return result.ToString();
        }
    }
}
