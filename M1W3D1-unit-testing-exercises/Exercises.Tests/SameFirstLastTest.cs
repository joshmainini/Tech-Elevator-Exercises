using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
	[TestClass]
	public class SameFirstLastTest
	{
		[TestMethod]
		public void IsItTheSame()
		{
			SameFirstLast mySameFirstLast = new SameFirstLast();
			Assert.AreEqual(false, mySameFirstLast.IsItTheSame(new int[] { 1, 2, 3 }));
			Assert.AreEqual(true, mySameFirstLast.IsItTheSame(new int[] { 1, 2, 3, 1 }));
			Assert.AreEqual(true, mySameFirstLast.IsItTheSame(new int[] { 1, 2, 1 }));

		}
	}
}
