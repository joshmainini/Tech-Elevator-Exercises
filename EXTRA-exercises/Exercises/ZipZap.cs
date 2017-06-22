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
        * Look for patterns like "zip" and "zap" in the string -- length-3, starting with 'z' and 
        * ending with 'p'. Return a string where for all such words, the middle letter is gone, 
        * so "zipXzap" yields "zpXzp".
        *
        * zipZap("zipXzap") → "zpXzp"
        * zipZap("zopzop") → "zpzp"
        * zipZap("zzzopzop") → "zzzpzp"        * 
        */
		public string ZipZap(string str)
		{
			string newStr = str;

			if (str.Length > 2)
			{
				for (int i = 0; i < newStr.Length - 2; i++)
				{
					if (newStr.Length > 2)
					{
						if (newStr[i] == 'z' &&  newStr[i + 2] == 'p')
						{
							newStr = newStr.Substring(0, i + 1) + newStr.Substring(i + 2);
							
						}
					}

				}
			}
			return newStr;
		}
	}
}
