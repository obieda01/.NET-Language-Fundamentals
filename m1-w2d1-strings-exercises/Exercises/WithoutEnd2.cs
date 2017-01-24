using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return a version without both the first and last char of the string. The string 
         may be any length, including 0.
         withouEnd2("Hello") → "ell"
         withouEnd2("abc") → "b"
         withouEnd2("ab") → ""
         */
        public string WithouEnd2(string str)
        {
           if(str==null|str.Length<=2) return "";
            String resultString = str.Substring(1);
            resultString = resultString.Substring(0, resultString.Length - 1);
            return resultString;
        }
    }
}
