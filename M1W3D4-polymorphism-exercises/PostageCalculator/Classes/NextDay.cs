using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
	public class NextDay : SPU
	{
		double rate;

		public override double CalculateRate(int distance, double weight)
		{
			return rate = (weight * 0.075) * distance;

		}
		public override string ToString()
		{
			return "SPU (next-day)";
		}
	}
}
