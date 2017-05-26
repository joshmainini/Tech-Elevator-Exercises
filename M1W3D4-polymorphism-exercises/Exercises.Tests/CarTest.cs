using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TollBoothCalculator;

namespace Exercises.Tests
{
	[TestClass]
	public class CarTest
	{
		[TestMethod]
		public void CarCalculateTollTest()
		{
			Car testCar = new Car(true);

			Assert.AreEqual(2, testCar.CalculateToll(50));

			Car testCar1 = new Car(false);

			Assert.AreEqual(1, testCar1.CalculateToll(50));
		}
	}
}
