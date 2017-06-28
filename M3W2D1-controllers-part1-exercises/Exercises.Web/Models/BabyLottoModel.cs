using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
	public class BabyLottoModel
	{
		public string Ticket1 { get; set; }
		public string Ticket2 { get; set; }
		public string Ticket3 { get; set; }
		public string Ticket4 { get; set; }
		public string Ticket5 { get; set; }

		public int LotteryScore1()
		{
			string[] stringNums = Ticket1.Split(',');
			int result = 0;

			if ((stringNums[0] == stringNums[1]) && (stringNums[0] == stringNums[2]) && (stringNums[2] == stringNums[1]))
			{
				result = 20;
			}
			else if ((stringNums[0] == stringNums[1]) || (stringNums[0] == stringNums[2]) || (stringNums[2] == stringNums[1]))
			{
				result = 10;
			}
			return result;

		}
		public int LotteryScore2()
		{
			string[] stringNums = Ticket2.Split(',');
			int result = 0;

			if ((stringNums[0] == stringNums[1]) && (stringNums[0] == stringNums[2]) && (stringNums[2] == stringNums[1]))
			{
				result = 20;
			}
			else if ((stringNums[0] == stringNums[1]) || (stringNums[0] == stringNums[2]) || (stringNums[2] == stringNums[1]))
			{
				result = 10;
			}
			return result;

		}
		public int LotteryScore3()
		{
			string[] stringNums = Ticket3.Split(',');
			int result = 0;

			if ((stringNums[0] == stringNums[1]) && (stringNums[0] == stringNums[2]) && (stringNums[2] == stringNums[1]))
			{
				result = 20;
			}
			else if ((stringNums[0] == stringNums[1]) || (stringNums[0] == stringNums[2]) || (stringNums[2] == stringNums[1]))
			{
				result = 10;
			}
			return result;

		}
		public int LotteryScore4()
		{
			string[] stringNums = Ticket4.Split(',');
			int result = 0;

			if ((stringNums[0] == stringNums[1]) && (stringNums[0] == stringNums[2]) && (stringNums[2] == stringNums[1]))
			{
				result = 20;
			}
			else if ((stringNums[0] == stringNums[1]) || (stringNums[0] == stringNums[2]) || (stringNums[2] == stringNums[1]))
			{
				result = 10;
			}
			return result;

		}
		public int LotteryScore5()
		{
			string[] stringNums = Ticket5.Split(',');
			int result = 0;

			if ((stringNums[0] == stringNums[1]) && (stringNums[0] == stringNums[2]) && (stringNums[2] == stringNums[1]))
			{
				result = 20;
			}
			else if ((stringNums[0] == stringNums[1]) || (stringNums[0] == stringNums[2]) || (stringNums[2] == stringNums[1]))
			{
				result = 10;
			}
			return result;

		}
	}
}
