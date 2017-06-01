using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FizzWriter
{
	public class FileWriter
	{
		public static void FizzBuzzWriter()
		{
			string directory = Environment.CurrentDirectory;
			string filename = "FizzBuzz.txt";
			string fullPath = Path.Combine(directory, filename);
			try
			{
				using (StreamWriter sw = new StreamWriter(fullPath))
				{
					for (int i = 1; i < 301; i++)
					{
						if ((i == 3 || i % 3 == 0) && (i == 5 || i % 5 == 0))
						{
							sw.WriteLine(i.ToString("FizzBuzz"));
						}
						else if (i == 3 || i % 3 == 0 || i.ToString().Contains("3"))
						{
							sw.WriteLine(i.ToString("Fizz"));
						}
						else if (i == 5 || i % 5 == 0 || i.ToString().Contains("5"))
						{
							sw.WriteLine(i.ToString("Buzz"));
						}
						else
						{
							sw.WriteLine(i);
						}
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

		}
	}
}
