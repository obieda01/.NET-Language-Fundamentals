﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*public  int[] findMaxMin(int[] sourceArray)
        {
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            foreach (var item in sourceArray)
            {
                if (item < minValue) minValue = item;
                if (item > maxValue) maxValue = item;
            }
            return new int[] { maxValue, minValue };
            

        }
         Given an array of ints, return true if the array contains no 1's and no 3's.
         lucky13([0, 2, 4]) → true
         lucky13([1, 2, 3]) → false
         lucky13([1, 2, 4]) → false
         */
        public bool Lucky13(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1 || nums[i] == 3) return false;
                        
            }
            return true;
        }

    }
}
