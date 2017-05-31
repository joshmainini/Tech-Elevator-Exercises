using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordSearch
{
	class FileReader
	{
		private int lineCount;
		private string search;

		public FileReader()
		{
			lineCount = 0;
		}
		public string Search
		{
			get
			{
				return search.ToLower();
			}
			set
			{
				search = value.ToLower();
			}
		}

		public string FullPath
		{
			get;set;
		}

		public void WordSearchFileReader()
		{
			try
			{
				using (StreamReader sr = new StreamReader(FullPath))
				{
					while (!sr.EndOfStream)
					{
						lineCount++;
						string line = sr.ReadLine();
						line = line.ToLower();

						if (line.Contains(Search))
						{
							Console.WriteLine(lineCount + ") " + line);
						}
					}
				}
			}
			catch (IOException e)
			{
				Console.WriteLine("File not found");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
