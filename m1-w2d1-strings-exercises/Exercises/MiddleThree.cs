﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string of odd length, return the string length 3 from its middle, so "Candy" yields "and". 
         The string length will be at least 3.
         middleThree("Candy") → "and"
         middleThree("and") → "and"
         middleThree("solving") → "lvi"
         */
        public string MiddleThree(string str)
        {
            if(str.Length%2==0) return null;
            if (str.Length < 3) return str;
            return str.Substring((str.Length/2)-1,3);
        }
    }
}
