using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
	public class TwoDayGround : SPU
	{
		double rate;

		public override double CalculateRate(int distance, double weight)
		{
			return rate = (weight * 0.050) * distance;

		}
		public override string ToString()
		{
			return "SPU (2-day business)";
		}
	}
}
