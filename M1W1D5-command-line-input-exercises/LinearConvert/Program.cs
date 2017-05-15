using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConvert
{
    class Program
    {
        /*
         The foot to meter conversion formula is:
 	        m = f * 0.3048
 	
         The meter to foot conversion formula is:
 	        f = m * 3.2808399
 	
         Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet.
         Convert the length to the opposite measurement, and display the old and new measurements to the console.
  
         C:\Users> LinearConvert
         Please enter the length: 58
         Is the measurement in (m)eter, or (f)eet? f
         58f is 17m.
         */

        static void Main(string[] args)
        {
			Console.WriteLine("Please enter the length: ");
			string stringLength = Console.ReadLine();
			Console.WriteLine("Is the measurement in (m)eters, or (f)eet? ");
			string lengthType = Console.ReadLine();

			double originalLength = double.Parse(stringLength);
			double result = 0;

			if (lengthType == "m")
			{
				result = originalLength * 3.2808399;
				Console.WriteLine($"{originalLength}m is {result}f");
			}
			if (lengthType == "f")
			{
				result = originalLength * 0.3048;
				Console.WriteLine($"{originalLength}f is {result}m");
			}

		}
    }
}
