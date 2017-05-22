using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
	public class Company
	{
		private string name;
		private int numberOfEmployees;
		private decimal revenue;
		private decimal expenses;

		public Company(string startingName)
		{
			name = startingName;
		}

		public string Name
		{
			get
			{
				return name;
			}
		}
		public int NumberOfEmployees
		{
			get; set;
		}
		public decimal Revenue
		{
			get; set;
		}
		public decimal Expenses
		{
			get; set;
		}

		public string GetCompanySize()
		{
			string companySize;
			if (numberOfEmployees < 50)
			{
				companySize = "small";
			}
			else if (numberOfEmployees >= 50 && numberOfEmployees <= 250)
			{
				companySize = "medium";
			}
			else
			{
				companySize = "large";
			}
			return companySize;

		}

		public decimal GetProfit()
		{
			decimal profit;
			profit = revenue - expenses;
			return profit;
		}

	}
}
