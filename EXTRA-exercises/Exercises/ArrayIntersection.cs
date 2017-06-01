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
        CHALLENGE: Using array A and array B, return an array that is the intersection of both A and B.
        The intersection includes numbers that appear in both arrays.

            ArrayIntersection([1, 3, 5], [1, 5, 7]) → [1, 5]
            ArrayIntersection([1], [1, 5, 7]) → [1]
            ArrayIntersection([1, 1, 1], [1, 5, 7]) → [1]
            ArrayIntersection([], []) → []
        */
		public int[] ArrayIntersection(int[] a, int[] b)
		{
			List<int> numberList = new List<int>();

			if (a.Length >= b.Length)
			{
				for (int i = 0; i < b.Length; i++)
				{
					if (a.Contains(b[i]))
					{
						numberList.Add(b[i]);
					}
				}
			}
			else
			{
				for (int i = 0; i < a.Length; i++)
				{
					if (b.Contains(a[i]))
					{
						numberList.Add(a[i]);
					}
				}
			}

			int[] c = numberList.ToArray();

			return c;
		}
	}
}
