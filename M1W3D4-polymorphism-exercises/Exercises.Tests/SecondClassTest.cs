using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
	[TestClass]
	public class SecondClassTest
	{
		[TestMethod]
		public void CalculateRateTest_ReallyLite()
		{
			SecondClass testClass = new SecondClass();

			Assert.AreEqual(0.175, testClass.CalculateRate(50, 2), 0.001);
		}

		[TestMethod]
		public void CalculateRateTest_ReallyHeavy()
		{
			SecondClass testClass = new SecondClass();

			Assert.AreEqual(2.50, testClass.CalculateRate(50, 150), 0.001);
		}

		[TestMethod]
		public void CalculateRateTest_MiddleWeight()
		{
			SecondClass testClass = new SecondClass();

			Assert.AreEqual(0.975, testClass.CalculateRate(50, 45), 0.001);
		}
	}
}
