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
        * Given 2 strings, a and b, return the number of the positions where they contain the same length 
        * 2 substring. So "xxcaazz" and "xxbaaz" yields 3, since the "xx", "aa", and "az" 
        * substrings appear in the same place in both strings.        * 
        *
        * stringMatch("xxcaazz", "xxbaaz") → 3
        * stringMatch("abc", "abc") → 2
        * stringMatch("abc", "axc") → 0  
        */
        public int StringMatch(string a, string b)
        {
			int count = 0;


			if ((a.Length > b.Length) && (a.Length > 2))
			{
				for (int i = 0; i < b.Length-1; i++)
				{
					if (b.Contains(a.Substring(i, i + 1)))
					{
						count++;
					}
				}
			}
			else if((b.Length > a.Length) && (b.Length > 2))
			{
				for (int i = 0; i < a.Length-1; i++)
				{
					if (a.Contains(b.Substring(i, i + 1)))
					{
						count++;
					}
				}
			}
            return count;
        }
    }
}
