using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
	[TestClass]
	public class FirstClassTest
	{
		[TestMethod]
		public void CalculateRateTest_ReallyLite()
		{
			FirstClass testClass = new FirstClass();

			Assert.AreEqual(1.75, testClass.CalculateRate(50, 2), 0.001);
		}

		[TestMethod]
		public void CalculateRateTest_ReallyHeavy()
		{
			FirstClass testClass = new FirstClass();

			Assert.AreEqual(25, testClass.CalculateRate(50, 150), 0.001);
		}

		[TestMethod]
		public void CalculateRateTest_MiddleWeight()
		{
			FirstClass testClass = new FirstClass();

			Assert.AreEqual(9.75, testClass.CalculateRate(50, 45), 0.001);
		}
	}
}
