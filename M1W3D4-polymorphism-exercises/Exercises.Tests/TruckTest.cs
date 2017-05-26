using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TollBoothCalculator;

namespace Exercises.Tests
{
	[TestClass]
	public class TruckTest
	{
		[TestMethod]
		public void CalculateTollTest()
		{
			Truck testTruck = new Truck(4);

			Assert.AreEqual(2, testTruck.CalculateToll(50));

			Truck testTruck1 = new Truck(6);

			Assert.AreEqual(2.25, testTruck1.CalculateToll(50));

			Truck testTruck2 = new Truck(10);

			Assert.AreEqual(2.40, testTruck2.CalculateToll(50));
		}
	}
}
