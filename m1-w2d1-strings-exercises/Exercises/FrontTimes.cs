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
         Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or 
         whatever is there if the string is less than length 3. Return n copies of the front;
         frontTimes("Chocolate", 2) → "ChoCho"
         frontTimes("Chocolate", 3) → "ChoChoCho"
         frontTimes("Abc", 3) → "AbcAbcAbc"
         */
        public string FrontTimes(string str, int n)
        {
            if (n < 0) return null;
            StringBuilder sb = new StringBuilder();
            string neededString = str.Length < 3 ? str : str.Substring(0, 3);
            for (int i = 0; i < n; i++)
            {
                sb.Append(neededString);
            }
            return sb.ToString();
        }

    }
}
