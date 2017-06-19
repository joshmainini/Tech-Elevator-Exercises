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
        CHALLENGE: Given a string, return the length of the largest "block" in the string. 
        A block is a run of adjacent chars that are the same.

        maxBlock("hoopla") → 2
        maxBlock("abbCCCddBBBxx") → 3
        maxBlock("") → 0
        */
        public int MaxBlock(string str)
        {
			List<int> intList = new List<int>();
			int count = 1;
			int resultCount = 0;

			for (int i = 0; i < str.Length; i++)
			{
				int x = 0;

				while (x < str.Length)
				{
					if (str[i] == str[i++])
					{
						count++;

						if (count > resultCount)
						{
							resultCount = count;
						}
					}
					else if (str[i] != str[i++])
					{
						count = 1;
					}
					x++;
				}
				intList.Add(resultCount);
			}
			intList.Reverse();

			return intList[0];
        }
    }
}
