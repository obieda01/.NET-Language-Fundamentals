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
        Given a string, return a string length 1 from its front, unless front is false, in which case 
        return a string length 1 from its back. The string will be non-empty.
        theEnd("Hello", true) → "H"
        theEnd("Hello", false) → "o"
        theEnd("oh", true) → "o"
        */
        public string TheEnd(string str, bool front)
        {

            if (str == null) return null;
            if (front) return str[0].ToString();
            else return str[str.Length - 1].ToString();
        }
    }
}
