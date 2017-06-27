using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
	public class OrderNameModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleInitial { get; set; }
		public string ListOrder { get; set; }

		public string NameOrdered()
		{
			if (ListOrder == "First MI Last")
			{
				string result = FirstName + " " + MiddleInitial + " " + LastName;
				return result;
			}
			else if (ListOrder == "First Last")
			{
				string result = FirstName + " " + LastName;
				return result;
			}
			else if (ListOrder == "Last, First MI")
			{
				string result = $"{LastName},{FirstName} {MiddleInitial}";
				return result;
			}
			else if (ListOrder == "Last, First")
			{
				string result = LastName + ", " + FirstName;
				return result;
			}
			return "";
		}

	}
}