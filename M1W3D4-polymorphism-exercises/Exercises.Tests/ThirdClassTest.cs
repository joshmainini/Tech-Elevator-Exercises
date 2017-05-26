using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
	[TestClass]
	public class ThirdClassTest
	{
		[TestMethod]
		public void CalculateRateTest_ReallyLite()
		{
			ThirdClass testClass = new ThirdClass();

			Assert.AreEqual(0.1, testClass.CalculateRate(50, 2), 0.001);
		}

		[TestMethod]
		public void CalculateRateTest_ReallyHeavy()
		{
			ThirdClass testClass = new ThirdClass();

			Assert.AreEqual(0.85, testClass.CalculateRate(50, 150), 0.001);
		}

		[TestMethod]
		public void CalculateRateTest_MiddleWeight()
		{
			ThirdClass testClass = new ThirdClass();

			Assert.AreEqual(0.75, testClass.CalculateRate(50, 45), 0.001);
		}
	}
}
