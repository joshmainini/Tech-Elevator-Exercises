using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TollBoothCalculator;
namespace Exercises.Tests
{
	[TestClass]
	public class TankTest1
	{
		[TestMethod]
		public void TankCalculateTollTest()
		{
			Tank testTank = new Tank();

			Assert.AreEqual(0, testTank.CalculateToll(99));
		}
	}
}
