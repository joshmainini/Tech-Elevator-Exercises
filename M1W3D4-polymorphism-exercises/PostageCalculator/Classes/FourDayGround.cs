using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
	public class FourDayGround : SPU
	{
		double rate;

		public override double CalculateRate(int distance, double weight)
		{
			return rate = (weight * 0.0050) * distance;
			
		}
		public override string ToString()
		{
			return "SPU (4-day ground)";
		}
	}
}
