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
        We'll say that a number is "teen" if it is in the range 13..19 inclusive. Given 3 int values, 
        return true if 1 or more of them are teen.
        hasTeen(13, 20, 10) → true
        hasTeen(20, 19, 10) → true
        hasTeen(20, 10, 13) → true
        */
        public bool HasTeen(int a, int b, int c)
		
        {
			bool isTeenA = a == 13 || a == 14 || a == 15 || a == 16 || a == 17 || a == 18 || a == 19;
			bool isTeenB = b == 13 || b == 14 || b == 15 || b == 16 || b == 17 || b == 18 || b == 19;
			bool isTeenC = c == 13 || c == 14 || c == 15 || c == 16 || c == 17 || c == 18 || c == 19;
			if (isTeenA || isTeenB || isTeenC)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

    }
}
