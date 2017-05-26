using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
	[TestClass]
	public class NextDayTest
	{
		[TestMethod]
		public void CalculateRateTest_NextDay()
		{

			NextDay testPackage = new NextDay();

			Assert.AreEqual(750, testPackage.CalculateRate(100, 100));
		}

		[TestMethod]
		public void CalculateRateTest_NextDay2()
		{
			NextDay testPackage = new NextDay();

			Assert.AreEqual(3.75, testPackage.CalculateRate(5, 10));
		}
	}

}
