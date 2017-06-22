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
        Return true if the array contains, somewhere, three increasing adjacent numbers like 
        .... 4, 5, 6, ... or 23, 24, 25.
        
        tripleUp([1, 4, 5, 6, 2]) → true
        tripleUp([1, 2, 3]) → true
        tripleUp([1, 2, 4]) → false
        */
        public bool TripleUp(int[] nums)
        {
			bool result = false;
			for(int i = 0; i < nums.Length-2; i++)
			{
				if ((nums[i + 1] == nums[i] + 1) && (nums[i + 2] == nums[i] + 2))
				{
					result = true;
				}
			}
			return result; 
        }
    }
}
