﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
	public class PostalService : IDeliveryDriver
	{
		public virtual double CalculateRate(int distance, double weight)
		{
			return 0;
		}
	}
}
