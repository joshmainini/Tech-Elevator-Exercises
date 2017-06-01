using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSplitter
{
	public class FileWriter
	{
		public static void SplitAndWrite()
		{
			int fileCount = 1;
			Console.WriteLine("What is the name of the input file?");
			string file = Console.ReadLine();
			string fileSubstring = file.Substring(0, file.Length - 4);
			string fileName = $"{fileSubstring}-{fileCount}.txt";


			Console.Write("How many lines of text (max) should there be in the split files?");
			int splitMax = int.Parse(Console.ReadLine());

			Console.WriteLine("How many lines of text will this file contain?");
			int totalLines = int.Parse(Console.ReadLine());

			string directory = Environment.CurrentDirectory;
			string fullPath = Path.Combine(directory, fileName);
			try
			{
				while (totalLines+splitMax > 0)
				{
					using (StreamWriter sw = new StreamWriter(fullPath))
					{
						for (int i = 1; i < splitMax + 1; i++)
						{
							sw.WriteLine(i);
						}
						sw.Close();
						totalLines -= splitMax;
						fileName = $"{fileSubstring}-{fileCount++}.txt";
						fullPath = Path.Combine(directory, fileName);
						StreamWriter sw1 = new StreamWriter(fullPath);
						{
							for (int i = 1; i < splitMax + 1; i++)
							{
								sw1.WriteLine(i);
							}
							sw1.Close();
							totalLines -= splitMax;
							fileName = $"{fileSubstring}-{fileCount++}.txt";
							fullPath = Path.Combine(directory, fileName);
						}

					}
				}
			}
			catch (IOException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
