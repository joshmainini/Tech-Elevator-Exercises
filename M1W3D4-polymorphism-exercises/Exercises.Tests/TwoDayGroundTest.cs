using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
	[TestClass]
	public class TwoDayGroundTest
	{
		[TestMethod]
		public void CalculateRateTest_TwoDayGround()
		{

			TwoDayGround testPackage = new TwoDayGround();

			Assert.AreEqual(500, testPackage.CalculateRate(100, 100));
		}

		[TestMethod]
		public void CalculateRateTest_TwoDayGround2()
		{
			TwoDayGround testPackage = new TwoDayGround();

			Assert.AreEqual(2.50, testPackage.CalculateRate(5, 10));
		}
	}
}
