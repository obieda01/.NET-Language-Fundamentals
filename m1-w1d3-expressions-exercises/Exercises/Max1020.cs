﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive, 
      or return 0 if neither is in that range.
      max1020(11, 19) → 19
      max1020(19, 11) → 19
      max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            if ((10 <= a && a <= 20) && (10 <= b && b <= 20))
            {
                if (a >= b) return a;
                else return b;
            }
            else if ((10 <= a && a <= 20)) return a;
            else if ((10 <= b && b <= 20)) return b;
            else return 0;
        }

    }
}
