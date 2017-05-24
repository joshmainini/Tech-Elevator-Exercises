using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
	[TestClass]
	public class WordCountTest
	{
		[TestMethod]
		public void GetCountTest()
		{

			Dictionary<string, int> Dictionary1 = new Dictionary<string, int>();
			Dictionary1.Add("ba", 2);
			Dictionary1.Add("black", 1);
			Dictionary1.Add("sheep", 1);

			Dictionary<string, int> Dictionary2 = new Dictionary<string, int>();
			Dictionary2.Add("b", 2);
			Dictionary2.Add("c", 1);
			Dictionary2.Add("a", 2);

			Dictionary<string, int> Dictionary3 = new Dictionary<string, int>();
			Dictionary3.Add("b", 1);
			Dictionary3.Add("c", 1);
			Dictionary3.Add("a", 1);
			
			WordCount myWordCount = new WordCount();
			

			CollectionAssert.AreEquivalent(Dictionary1, myWordCount.GetCount(new string[] { "ba", "ba", "black", "sheep" }));
			CollectionAssert.AreEquivalent(Dictionary2, myWordCount.GetCount(new string[] { "a", "b", "a", "c", "b" }));
			CollectionAssert.AreEquivalent(Dictionary3, myWordCount.GetCount(new string[] { "c", "b", "a"}));
			
		}
	}
}
