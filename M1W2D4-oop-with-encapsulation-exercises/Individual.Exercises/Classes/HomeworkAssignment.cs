using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
	public class HomeworkAssignment
	{
		private int totalMarks;
		private int possibleMarks;
		private string submitterName;
		private string letterGrade;
		
		public HomeworkAssignment(int possibleMarks)
		{
			this.possibleMarks = possibleMarks;
		}

		public int TotalMarks
		{
			get
			{
				return totalMarks;
			}
			set
			{
				totalMarks = value;
			}
		}
		public int PossibleMarks
		{
			get
			{
				return possibleMarks;
			}
		}
		public string SubmitterName
		{
			get
			{
				return submitterName;
			}
			set
			{
				submitterName = value;
			}
		}
		public string LetterGrade
		{
			get
			{
				double result = totalMarks / possibleMarks;
				if (result >= 0.90)
				{
					letterGrade = "A";
				}
				else if (result >= 0.80)
				{
					letterGrade = "B";
				}
				else if (result >= 0.70)
				{
					letterGrade = "C";
				}
				else if (result >= 0.60)
				{
					letterGrade = "D";
				}
				else
				{
					letterGrade = "F";
				}

				return letterGrade;
			}
		}
	}
}




