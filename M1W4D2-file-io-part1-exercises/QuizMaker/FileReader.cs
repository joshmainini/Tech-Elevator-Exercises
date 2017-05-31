using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizMaker
{
	class FileReader
	{
		public static void ReadAFile()
		{
			string directory = Environment.CurrentDirectory;
			string filename = "sample-quiz-file.txt";
			string fullPath = Path.Combine(directory, filename);

			try
			{
				using (StreamReader sr = new StreamReader(fullPath))
				{
					while (!sr.EndOfStream)
					{
						int correctAnswers = 0;
						string line = sr.ReadLine();
						string[] lines = line.Split('|');
						foreach (string word in lines)
						{
							if (word.Contains('*'))
							{
								word.Replace('*', ' ');
							}
						}


						Console.WriteLine(lines[0]);
						Console.WriteLine("1.{0}", lines[1]);
						Console.WriteLine("2.{0}", lines[2]);
						Console.WriteLine("3.{0}", lines[3]);
						Console.WriteLine("4.{0}", lines[4]);

						Console.WriteLine();
						Console.Write("Your answer: ");
						string stringAnswer = Console.ReadLine();
						int answer = int.Parse(stringAnswer);
						Console.WriteLine();
						if (answer == 2)
						{
							Console.WriteLine("You answered correct!");
							correctAnswers++;
						}
						else
						{
							Console.WriteLine("Sorry, that isn't correct!");
						}
					}
				}
			}
			catch (IOException e)
			{
				Console.WriteLine("Error reading the file");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
	
