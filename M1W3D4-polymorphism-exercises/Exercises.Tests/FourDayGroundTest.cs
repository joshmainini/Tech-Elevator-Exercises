using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
	[TestClass]
	public class FourDayGroundTest
	{
		[TestMethod]
		public void CalculateRateTest_FourDayGround()
		{
			FourDayGround testPackage = new FourDayGround();

			Assert.AreEqual(50, testPackage.CalculateRate(100, 100));
		}

		[TestMethod]
		public void CalculateRateTest_FourDayGround2()
		{
			FourDayGround testPackage = new FourDayGround();

			Assert.AreEqual(0.25, testPackage.CalculateRate(5, 10));
		}
	}
}
