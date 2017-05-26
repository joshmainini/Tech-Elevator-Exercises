using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator
{
	public class Car : IVehicle
	{
		private bool hasTrailer;

		public Car (bool hasTrailer) : base()
		{
			this.hasTrailer = hasTrailer;
		}
		public bool HasTrailer
		{
			get;
		}
		public double CalculateToll(int distance)
		{
			double toll;

			if (hasTrailer == false)
			{
				toll = distance * 0.020;
			}
			else
			{
				toll = (distance * 0.020) + 1.00;
			}
			return toll;
		}
		public override string ToString()
		{
			return "Car";
		}

	}
}
