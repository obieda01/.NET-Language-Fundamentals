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
         Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start. 
         The string length will be at least 2.
         right2("Hello") → "loHel"
         right2("java") → "vaja"
         right2("Hi") → "Hi"
         */
        public string Right2(string str)
        {
            if (str == null) return null;
            if (str.Length < 2) return str;
            return str.Substring(str.Length - 2) + str.Substring(0, str.Length -2);
        }
    }
}
