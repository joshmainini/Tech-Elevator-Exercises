﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
	public class SecondClass : PostalService
	{
		public override double CalculateRate(int distance, double weight)
		{
			double rate;

			if (weight <= 2)
			{
				rate = 0.0035 * distance;
			}
			else if (weight <= 8)
			{
				rate = 0.0040 * distance;
			}
			else if (weight <= 15)
			{
				rate = 0.0047 * distance;
			}
			else if (weight <= 48)
			{
				rate = 0.0195 * distance;
			}
			else if (weight <= 128)
			{
				rate = 0.0450 * distance;
			}
			else
			{
				rate = 0.0500 * distance;
			}
			return rate;
		}
		public override string ToString()
		{
			return "Postal Service (2nd Class)";
		}
	}
}
