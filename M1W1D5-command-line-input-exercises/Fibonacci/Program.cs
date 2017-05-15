using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
	class Program
	{
		/*
         The Fibonacci numbers are the integers in the following sequence:  
	        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
         By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
 
         Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.
  
         C:\Users> Fiboncci
         Please enter the Fibonacci number: 25
         
         0, 1, 1, 2, 3, 5, 8, 13, 21
         */
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the Fibonacci number: ");
			string stringNumber = Console.ReadLine();
			int fibNumber = int.Parse(stringNumber);

			int i;

			int[] fibonacciNumbers = new int[15];
			fibonacciNumbers[0] = 0;
			fibonacciNumbers[1] = 1;
			fibonacciNumbers[2] = 1;

			for (i = 2; i < fibonacciNumbers.Length; i++)
			{
				fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
				if (fibonacciNumbers[i] < fibNumber)
				{
						if (fibonacciNumbers[i] != 0)
						{
							Console.WriteLine(fibonacciNumbers[i] + " ");
						}	
				}
			}
		}
	}
}
