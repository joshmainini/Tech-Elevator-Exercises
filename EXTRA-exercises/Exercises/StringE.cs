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
        * Return true if the given string contains between 1 and 3 'e' chars.
        * ("Hello") → true
        * ("Heelle") → true
        * ("Heelele") → false
        */
        public bool StringE(string str)
        {
			bool result = false;
			int count = 0;

			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == 'e')
				{
					count++;
				}
			}
			if ((count > 0) && (count < 4))
			{
				result = true;
			}
			return result;
        }
    }
}
