using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
	public class Airplane
	{
		private string planeNumber;
		private int bookedFirstClassSeats;
		private int availableFirstClassSeats;
		private int totalFirstClassSeats;
		private int bookedCoachSeats;
		private int availableCoachSeats;
		private int totalCoachSeats;

		public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
		{
			this.planeNumber = planeNumber;
			this.totalFirstClassSeats = totalFirstClassSeats;
			this.totalCoachSeats = totalCoachSeats;
		}

		public string PlaneNumber 
		{
			get
			{
				return planeNumber;
			}
		}
		public int BookedFirstClassSeats
		{
			get
			{
				return bookedFirstClassSeats;
			}
		}
		public int AvailableFirstClassSeats
		{
			get
			{
				availableFirstClassSeats = totalFirstClassSeats - bookedFirstClassSeats;
				return availableFirstClassSeats;
			}
		}
		public int TotalFirstClassSeats
		{
			get
			{
				return totalFirstClassSeats;
			}
		}
		public int BookedCoachSeats
		{
			get
			{
				return bookedCoachSeats;
			}
		}
		public int AvailbleCoachSeats
		{
			get
			{
				availableCoachSeats = totalCoachSeats - bookedCoachSeats;
				return availableCoachSeats;
			}
		}
		public int TotalCoachSeats
		{
			get
			{
				return totalCoachSeats;
			}
		}
		public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
		{
			bool result = false;

			if (forFirstClass == true && availableFirstClassSeats > totalNumberOfSeats)
			{
				bookedFirstClassSeats += totalNumberOfSeats;
				result = true;
			}
			if (forFirstClass == false &&  availableCoachSeats > totalNumberOfSeats)
			{
				bookedCoachSeats += totalNumberOfSeats;
				result = true;
			}
			return result;
		}


	}
}
