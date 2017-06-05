using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
	public partial class Exercises
	{
		/*
        Given an integer array, return the array sorted lowest to highest.
        CHALLENGE: Write the Sort algorithm, don't use the .Sort() method provided to an array. 

        sort([8, 13, 9, 12]) → [8, 9, 12, 13]        
        */
		public int[] ArraySort(int[] nums)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] > nums[j])
					{
						nums[i] = nums[i] + nums[j];
						nums[j] = nums[i] - nums[j];
						nums[i] = nums[i] - nums[j];
					}
				}
			}
			return nums;

		}
	}
}

