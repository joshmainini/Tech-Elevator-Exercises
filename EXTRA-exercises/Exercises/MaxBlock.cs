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
			Dictionary<char, int> resultDictionary = new Dictionary<char, int>();
			List<int> resultList = new List<int>();
			int count = 1;
			int result = 0;

			for (int i = 0; i < str.Length-1; i++)
			{
				int x = 1;
				if (str[i] == str[i + 1])
				{
					if ((i + 1) != (str.Length - 1))
					{
						bool flag = true;

						while ((str[i] == str[i + x]) && flag)
						{
							count++;
							if (i + x != str.Length - 1)
							{
								x++;
							}
							else
							{
								flag = false;
							}
						}
					}
					else
					{
						count++;
					}
					if (!resultDictionary.ContainsKey(str[i]))
					{
						resultDictionary.Add(str[i], count);
					}
					else if (resultDictionary.ContainsKey(str[i]) && (count > resultDictionary[str[i]]))
					{
						resultDictionary.Remove(str[i]);
						resultDictionary.Add(str[i], count);
					}
				}
				count = 1;
			}
			foreach (KeyValuePair<char, int> kvp in resultDictionary)
			{
				resultList.Add(kvp.Value);
			}
			resultList.Sort();

			if (resultList.Count > 0)
			{
				result = resultList[resultList.Count - 1];
			}
			else if (str.Length > 0)
			{
				result = 1;
			}
			return result;
        }
    }
}
