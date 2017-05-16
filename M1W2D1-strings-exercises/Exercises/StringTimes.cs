using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string and a non-negative int n, return a larger string that is n copies of the original string.
         stringTimes("Hi", 2) → "HiHi"
         stringTimes("Hi", 3) → "HiHiHi"
         stringTimes("Hi", 1) → "Hi"
         */
        public string StringTimes(string str, int n)
        {
			int i = 0;
			string result = "";

			while (i < n)
			{
				result += str;
				i++;
			}
			return result;
        }
    }
}
