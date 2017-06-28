using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
	public class FizzBuzzModel
	{
		public int DivisableBy1 { get; set; }
		public int DivisableBy2 { get; set; }
		public string Fizz { get; set; }
		public string Buzz { get; set; }
		public int Number1 { get; set; }
		public int Number2 { get; set; }
		public int Number3 { get; set; }
		public int Number4 { get; set; }
		public int Number5 { get; set; }

		public List<string> FizzBuzzer()
		{
			List<string> result = new List<string>();

			if ((Number1 % DivisableBy1 == 0) && (Number1 % DivisableBy2 == 0))
			{
				result.Add(Number1.ToString() + " " + Fizz + Buzz);
			}
			else if (Number1 % DivisableBy1 == 0)
			{
				result.Add(Number1.ToString() + " " + Fizz);
			}
			else if (Number1 % DivisableBy2 == 0)
			{
				result.Add(Number1.ToString() + " " + Buzz);
			}
			else
			{
				result.Add(Number1.ToString());
			}

			if ((Number2 % DivisableBy1 == 0) && (Number2 % DivisableBy2 == 0))
			{
				result.Add(Number2.ToString() + " " + Fizz + Buzz);
			}
			else if (Number2 % DivisableBy1 == 0)
			{
				result.Add(Number2.ToString() + " " + Fizz);
			}
			else if (Number2 % DivisableBy2 == 0)
			{
				result.Add(Number2.ToString() + " " + Buzz);
			}
			else
			{
				result.Add(Number2.ToString());
			}

			if ((Number3 % DivisableBy1 == 0) && (Number3 % DivisableBy2 == 0))
			{
				result.Add(Number3.ToString() + " " + Fizz + Buzz);
			}
			else if (Number3 % DivisableBy1 == 0)
			{
				result.Add(Number3.ToString() + " " + Fizz);
			}
			else if (Number3 % DivisableBy2 == 0)
			{
				result.Add(Number3.ToString() + " " + Buzz);
			}
			else
			{
				result.Add(Number3.ToString());
			}

			if ((Number4 % DivisableBy1 == 0) && (Number4 % DivisableBy2 == 0))
			{
				result.Add(Number4.ToString() + " " + Fizz + Buzz);
			}
			else if (Number4 % DivisableBy1 == 0)
			{
				result.Add(Number4.ToString() + " " + Fizz);
			}
			else if (Number4 % DivisableBy2 == 0)
			{
				result.Add(Number4.ToString() + " " + Buzz);
			}
			else
			{
				result.Add(Number4.ToString());
			}

			if ((Number5 % DivisableBy1 == 0) && (Number5 % DivisableBy2 == 0))
			{
				result.Add(Number5.ToString() + " " + Fizz + Buzz);
			}
			else if (Number5 % DivisableBy1 == 0)
			{
				result.Add(Number5.ToString() + " " + Fizz);
			}
			else if (Number5 % DivisableBy2 == 0)
			{
				result.Add(Number5.ToString() + " " + Buzz);
			}
			else
			{
				result.Add(Number5.ToString());
			}

			return result;
		}
	}
}