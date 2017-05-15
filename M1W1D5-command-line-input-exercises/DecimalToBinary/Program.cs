using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        /*
        Write a command line program which prompts the user for a series of decimal integer values  
        and displays each decimal value as itself and its binary equivalent

        C:\Users> DecimalToBinary
        
        Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321
        
        460 in binary is 111001100
        8218 in binary is 10000000011010
        1 in binary is 1
        31313 in binary is 111101001010001
        987654321 in binary is 111010110111100110100010110001
        */

        static void Main(string[] args)
        {
			Console.Write("Please enter in a series of decimal values (separated by spaces): ");
			string[] decimalString = Console.ReadLine().Split(' ');
			int[] decimalNumber = new int[decimalString.Length];

			for (int i = 0; i < decimalString.Length; i++)
			{
				int x = int.Parse(decimalString[i]);
				decimalNumber[i] = x;
			}

			int remainder;
			for (int i = 0; i < decimalNumber.Length; i++)
			{
				string result = string.Empty;
				while (decimalNumber[i] > 0)
				{
					remainder = decimalNumber[i] % 2;
					decimalNumber[i] /= 2;
					result = remainder.ToString() + result;
				}
				Console.WriteLine(decimalNumber[i] + " " + "in binary is" + " " + result);
			}

			

		}
    }
}
