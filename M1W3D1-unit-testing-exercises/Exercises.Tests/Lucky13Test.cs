using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
	[TestClass]
	public class Lucky13Test
	{
		[TestMethod]
		public void GetLuckyTest()
		{
			Lucky13 myLucky13 = new Lucky13();
			Assert.AreEqual(true, myLucky13.GetLucky(new int[] { 0, 2, 4 }));
			Assert.AreEqual(false, myLucky13.GetLucky(new int[] { 1, 2, 3 }));
			Assert.AreEqual(false, myLucky13.GetLucky(new int[] { 1, 2, 4 }));
		}
	}
}
