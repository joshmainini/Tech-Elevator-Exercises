using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechElevator.Classes;
using CompanyExercise;

namespace CompanyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
			Company companyA = new Company("The Apple Factory");
			companyA.Revenue = 100000;
			companyA.Expenses = 95000;

			Console.WriteLine();

			/*
             * Feel free to use this file to instante a few objects and see how they can be used
             * in a program. While code you put here must compile, it won't be validated by the automatic
             * testing. We are more focused with the mechanics of implementing the class.
             */
		}
    }
}
