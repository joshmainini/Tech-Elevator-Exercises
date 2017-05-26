using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
	public class ThirdClass : PostalService
	{
		public override double CalculateRate(int distance, double weight)
		{
			double rate;

			if (weight <= 2)
			{
				rate = 0.0020 * distance;
			}
			else if (weight <= 8)
			{
				rate = 0.0022 * distance;
			}
			else if (weight <= 15)
			{
				rate = 0.0024 * distance;
			}
			else if (weight <= 48)
			{
				rate = 0.0150 * distance;
			}
			else if (weight <= 128)
			{
				rate = 0.0160 * distance;
			}
			else
			{
				rate = 0.0170 * distance;
			}
			return rate;
		}
		public override string ToString()
		{
			return "Postal Service (3rd Class)";
		}
	}
}
