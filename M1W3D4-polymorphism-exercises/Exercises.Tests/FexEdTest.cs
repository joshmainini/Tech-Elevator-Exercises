using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
	[TestClass]
	public class FexEdTest
	{
		[TestMethod]
		public void CalculateRateTest_Greater500()
		{
			FexEd testPackage = new FexEd();

			Assert.AreEqual(25.00, testPackage.CalculateRate(501, 20));
		}

		[TestMethod]
		public void CalculateRateTest_DistanceAndWeight()
		{
			FexEd testPackage = new FexEd();

			Assert.AreEqual(28.00, testPackage.CalculateRate(501, 50));
		}

		[TestMethod]
		public void CalculateRateTest_FlatRate()
		{
			FexEd testPackage = new FexEd();

			Assert.AreEqual(20.00, testPackage.CalculateRate(200, 20));
		}
	}
}
