using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
	public class LastTwoModel
	{
		public string word1 { get; set; }
		public string word2 { get; set; }
		public string word3 { get; set; }
		public string word4 { get; set; }
		public string word5 { get; set; }
		public string word6 { get; set; }
		public string word7 { get; set; }
		public string word8 { get; set; }
		public string word9 { get; set; }
		public string word10 { get; set; }


		public string Reverse1()
		{
			List<char> charList = new List<char>();
			string result = "";

			for (int i = 0; i < word1.Length; i++)
			{
				if (i == word1.Length - 2)
				{
					charList.Add(word1[i + 1]);
				}
				else if (i == word1.Length - 1)
				{
					charList.Add(word1[i - 1]);
				}
				else
				{
					charList.Add(word1[i]);
				}
			}
			foreach (char c in charList)
			{
				result = result + c;
			}

			return result;
		}
		public string Reverse2()
		{
			List<char> charList = new List<char>();
			string result = "";

			for (int i = 0; i < word2.Length; i++)
			{
				if (i == word2.Length - 2)
				{
					charList.Add(word2[i + 1]);
				}
				else if (i == word2.Length - 1)
				{
					charList.Add(word2[i - 1]);
				}
				else
				{
					charList.Add(word2[i]);
				}
			}
			foreach (char c in charList)
			{
				result = result + c;
			}

			return result;
		}
		public string Reverse3()
		{
			List<char> charList = new List<char>();
			string result = "";

			for (int i = 0; i < word3.Length; i++)
			{
				if (i == word3.Length - 2)
				{
					charList.Add(word3[i + 1]);
				}
				else if (i == word3.Length - 1)
				{
					charList.Add(word3[i - 1]);
				}
				else
				{
					charList.Add(word3[i]);
				}
			}
			foreach (char c in charList)
			{
				result = result + c;
			}

			return result;
		}
		public string Reverse4()
		{
			List<char> charList = new List<char>();
			string result = "";

			for (int i = 0; i < word4.Length; i++)
			{
				if (i == word4.Length - 2)
				{
					charList.Add(word4[i + 1]);
				}
				else if (i == word4.Length - 1)
				{
					charList.Add(word4[i - 1]);
				}
				else
				{
					charList.Add(word4[i]);
				}
			}
			foreach (char c in charList)
			{
				result = result + c;
			}

			return result;
		}
		public string Reverse5()
		{
			List<char> charList = new List<char>();
			string result = "";

			for (int i = 0; i < word5.Length; i++)
			{
				if (i == word5.Length - 2)
				{
					charList.Add(word5[i + 1]);
				}
				else if (i == word5.Length - 1)
				{
					charList.Add(word5[i - 1]);
				}
				else
				{
					charList.Add(word5[i]);
				}
			}
			foreach (char c in charList)
			{
				result = result + c;
			}

			return result;
		}
		public string Reverse6()
		{
			List<char> charList = new List<char>();
			string result = "";

			for (int i = 0; i < word6.Length; i++)
			{
				if (i == word6.Length - 2)
				{
					charList.Add(word6[i + 1]);
				}
				else if (i == word6.Length - 1)
				{
					charList.Add(word6[i - 1]);
				}
				else
				{
					charList.Add(word6[i]);
				}
			}
			foreach (char c in charList)
			{
				result = result + c;
			}

			return result;
		}
		public string Reverse7()
		{
			List<char> charList = new List<char>();
			string result = "";

			for (int i = 0; i < word7.Length; i++)
			{
				if (i == word7.Length - 2)
				{
					charList.Add(word7[i + 1]);
				}
				else if (i == word7.Length - 1)
				{
					charList.Add(word7[i - 1]);
				}
				else
				{
					charList.Add(word7[i]);
				}
			}
			foreach (char c in charList)
			{
				result = result + c;
			}

			return result;
		}
		public string Reverse8()
		{
			List<char> charList = new List<char>();
			string result = "";

			for (int i = 0; i < word8.Length; i++)
			{
				if (i == word8.Length - 2)
				{
					charList.Add(word8[i + 1]);
				}
				else if (i == word8.Length - 1)
				{
					charList.Add(word8[i - 1]);
				}
				else
				{
					charList.Add(word8[i]);
				}
			}
			foreach (char c in charList)
			{
				result = result + c;
			}

			return result;
		}
		public string Reverse9()
		{
			List<char> charList = new List<char>();
			string result = "";

			for (int i = 0; i < word9.Length; i++)
			{
				if (i == word9.Length - 2)
				{
					charList.Add(word9[i + 1]);
				}
				else if (i == word9.Length - 1)
				{
					charList.Add(word9[i - 1]);
				}
				else
				{
					charList.Add(word9[i]);
				}
			}
			foreach (char c in charList)
			{
				result = result + c;
			}

			return result;
		}
		public string Reverse10()
		{
			List<char> charList = new List<char>();
			string result = "";

			for (int i = 0; i < word10.Length; i++)
			{
				if (i == word10.Length - 2)
				{
					charList.Add(word10[i + 1]);
				}
				else if (i == word10.Length - 1)
				{
					charList.Add(word10[i - 1]);
				}
				else
				{
					charList.Add(word10[i]);
				}
			}
			foreach (char c in charList)
			{
				result = result + c;
			}

			return result;
		}
	}
}