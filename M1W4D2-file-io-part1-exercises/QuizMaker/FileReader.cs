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
			int x = 0;
			string directory = Environment.CurrentDirectory;
			string filename = "sample-quiz-file.txt";
			string fullPath = Path.Combine(directory, filename);
			int numberOfCorrectAnswers = 0;

			try
			{
				using (StreamReader sr = new StreamReader(fullPath))
				{
					while (!sr.EndOfStream)
					{
						string line = sr.ReadLine();
						string[] lines = line.Split('|');
						for(int i = 0; i< lines.Length; i++)
						{
							if (lines[i].Contains('*'))
							{
								lines[i] = lines[i].Replace('*', ' ');
								x = i++;
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
						if (answer == x)
						{
							Console.WriteLine("You answered correct!");
							Console.WriteLine();
							numberOfCorrectAnswers++;
						}
						else
						{
							Console.WriteLine("Sorry, that isn't correct!");
							Console.WriteLine();
						}
					}
					Console.WriteLine();
					Console.WriteLine($"You got {numberOfCorrectAnswers} answer(s) correct out of the total two asked!");
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
	
