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
        We'll say that a number is "teen" if it is in the range 13..19 inclusive. Given 2 int values,
        return true if one or the other is teen, but not both.
        loneTeen(13, 99) → true
        loneTeen(21, 19) → true
        loneTeen(13, 13) → false
        */
        public bool LoneTeen(int a, int b)
        {
            if ((13 <= a && a <= 19) && (13 <= b && b <= 19)) return false;
            else
            {
                if ((13 <= a && a <= 19) || (13 <= b && b <= 19))
                    return true;
                else return false;
            }
        }

    }
}
