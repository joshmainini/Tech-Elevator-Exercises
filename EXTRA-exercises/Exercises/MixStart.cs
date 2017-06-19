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
        * Return true if the given string begins with "mix", except the 'm' can be anything, so "pix", "9ix" .. all count.
        * mixStart("mix snacks") → true
        * mixStart("pix snacks") → true
        * mixStart("piz snacks") → false        
        */
        public bool MixStart(string str)
        {
			bool result = false;
			if (str.Length > 2)
			{
				if (str[1] == 'i' && str[2] == 'x')
				{
					result = true;
				}
			}
			else
			{
				result = false;
			}
			return result;
        }
    }
}
