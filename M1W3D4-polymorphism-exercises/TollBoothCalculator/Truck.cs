using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator
{
	public class Truck : IVehicle
	{
		private int numberOfAxels;

		public Truck(int numberOfAxels) :base()
		{
			this.numberOfAxels = numberOfAxels;
		}
		public int NumberOfAxels
		{
			get;
		}
		public double CalculateToll(int distance)
		{
			double toll;
			switch (numberOfAxels)
			{
				case 4:
					toll = 0.040 * distance;
					break;

				case 6:
					toll = 0.045 * distance;
					break;
				case 8:
					toll = 0.048 * distance;
					break;
				default:
					toll = 0.048 * distance;
					break;
			}
				return toll;
		}
		public override string ToString()
		{
			return "Truck";
		}
	}
}
