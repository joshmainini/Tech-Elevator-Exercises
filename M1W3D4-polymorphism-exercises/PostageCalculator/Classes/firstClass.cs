using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
	class firstClass : PostalService
	{
		public override double CalculateRate(int distance, double weight)
		{
			double rate;

			if (weight <= 2)
			{
				rate = 0.035 * distance;
			}
			else if (weight <= 8)
			{
				rate = 0.040 * distance;
			}
			else if (weight <= 15)
			{
				rate = 0.047 * distance;
			}
			else if (weight <= 48)
			{
				rate = 0.195 * distance;
			}
			else if (weight <= 128)
			{
				rate = 0.450 * distance;
			}
			else
			{
				rate = 0.500 * distance;
			}
			return rate;
		}
	}
}
