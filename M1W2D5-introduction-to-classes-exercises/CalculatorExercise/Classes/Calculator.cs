using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
		private int result;

		public Calculator(int startingResult)
		{
			result = startingResult;
		}

		public int Result
		{
			get
			{
				return result;
			}
		}

		public int Add(int addend)
		{
			result = result + addend;
			return result;
		}
		public int Subtract(int subtrahend)
		{
			result = result - subtrahend;
			return result;
		}
		public int Multiply(int multiplier)
		{
			result = result * multiplier;
			return result;
		}
		public int Power(int exponent)
		{
			if (result < 0)
			{
				result *= -1;
			}

			result = (int)Math.Pow(result, exponent);
			
			return result;
		}
		public void Reset()
		{
			result = 0;
		}

	}
}

