using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
	public class FexEd : IDeliveryDriver
	{
			double rate;

		public virtual double CalculateRate(int distance, double weight)
		{
			if (weight > 48 && distance > 500)
			{
				rate = 20.00 + 5.00 + 3.00;
			}
			else if (distance > 500)
			{
				rate = 20.00 + 5.00;
			}
			else if (weight > 48)
			{
				rate = 20.00 + 3.00;
			}
			else
			{
				rate = 20.00;
			}
			return rate;
		}
		public override string ToString()
		{
			return "FexEd";
		}
	}
}

