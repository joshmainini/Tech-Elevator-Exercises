﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    { 
        /*
         Given 2 int values, return true if they are both in the range 30..40 inclusive, or they are both 
         in the range 40..50 inclusive.
         in3050(30, 31) → true
         in3050(30, 41) → false
         in3050(40, 50) → true
         */
        public bool In3050(int a, int b)
        {
			bool lowInRange = ((a >= 30) && (a <= 40)) && ((b >= 30) && (b <= 40)); 
			bool highInRange = ((a >= 40) && (b <= 50)) && ((b >= 40) && (b <= 50)); 
			if (lowInRange || highInRange)
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
