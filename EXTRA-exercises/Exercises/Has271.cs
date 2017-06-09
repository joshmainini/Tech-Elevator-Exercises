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
        * Given an array of ints, return true if it contains a 2, 7, 1 pattern -- a value, followed by 
        * the value plus 5, followed by the value minus 1. 
        * Additionally the 271 counts even if the "1" differs by 2 or less from the correct value.
        * 
        * has271([1, 2, 7, 1]) → true
        * has271([1, 2, 8, 1]) → false
        * has271([2, 7, 1]) → true     
        */
        public bool Has271(int[] nums)
        {
			bool result = false;

			if (nums.Length < 3)
			{
				return result;
			}
			for (int i = 0; i < nums.Length-1; i++)
			{
				if (nums[i] + 5 == nums[i + 1])
				{
					if (Math.Abs((nums[i] - 1) - nums[i + 2]) <= 2)
					{
						result = true; 
					}
				}
			}
            return result;
        }
    }
}
