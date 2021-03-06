﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
	public class KataRomanNumerals
	{

		Dictionary<string, int> rmDictionary = new Dictionary<string, int>()
		{
			{"I",1 },
			{"IV",4 },
			{"V",5 },
			{"IX",9 },
			{"X",10 },
			{"XL",40 },
			{"L",50 },
			{"XC",90 },
			{"C",100 },
			{"CL",150 },
			{"CD",400 },
			{"D",500 },
			{"DC",600 },
			{"CM",900 },
			{"M", 1000 },
			{"MM", 2000 },
		 };

		public string ConvertToRomanNumeral(int n)
		{
			string result = "";
			while (n > 0)
			{

				if (n > 3000 || n < 0)
				{
					return "Number out of range";
				}
				if (n >= 1000)
				{
					result = "M";
					n = n - 1000;
				}
				if (n >= 1000)
				{
					result = result + "M";
					n = n - 1000;
				}

				if (n >= 900)
				{
					result = result + "CM";
					n = n - 900;
				}
				if (n >= 500)
				{
					result = result + "D";
					n = n - 500;
				}
				if (n >= 400)
				{
					result = result + "CD";
					n = n - 400;
				}
				if (n >= 100)
				{
					result = result + "C";
					n = n - 100;
				}
				if (n >= 90)
				{
					result = result + "XC";
					n = n - 90;
				}
				if (n >= 50)
				{
					result = result + "L";
					n = n - 50;
				}
				if (n >= 40)
				{
					result = result + "XL";
					n = n - 40;
				}
				if (n >= 10)
				{
					result = result + "X";
					n = n - 10;
				}
				if (n >= 9)
				{
					result = result + "IX";
					n = n - 9;
				}
				if (n >= 5)
				{
					result = result + "V";
					n = n - 5;
				}
				if (n >= 4)
				{
					result = result + "IV";
					n = n - 4;
				}
				if (n >= 1)
				{
					result = result + "I";
					n = n - 1;
				}
			}
			return result;
		}
		public int ConvertToDigit(string romanNumeral)
		{
			int result = 0;

			if (romanNumeral.Length == 1)
			{
				result = rmDictionary[romanNumeral];
			}
			else
			{
				for (int i = 0; i < romanNumeral.Length-1; i++)
				{
					string rmSubstring = romanNumeral.Substring(i, 2);

					if (rmDictionary.ContainsKey(rmSubstring))
					{
						result += rmDictionary[rmSubstring];
						romanNumeral = romanNumeral.Substring(1);
					}
					else if (rmDictionary.ContainsKey(romanNumeral[i].ToString()))
					{
						result += rmDictionary[romanNumeral[i].ToString()];
					}
				}
			}
			return result;
		}
	}
}
			










