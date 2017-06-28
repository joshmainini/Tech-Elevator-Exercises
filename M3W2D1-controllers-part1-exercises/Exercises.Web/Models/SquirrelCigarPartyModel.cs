using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
	public class SquirrelCigarPartyModel
	{
		public int NumberOfSquirrels { get; set; }
		public bool IsWeekend { get; set; }

		public bool SuccessfulParty()
		{
			bool result = false;

			if ((IsWeekend) && (NumberOfSquirrels >= 40))
			{
				result = true;
			}
			else if ((IsWeekend == false) && (NumberOfSquirrels >= 40) && (NumberOfSquirrels <= 60))
			{
				result = true;
			}
			return result;
		}
	}
}