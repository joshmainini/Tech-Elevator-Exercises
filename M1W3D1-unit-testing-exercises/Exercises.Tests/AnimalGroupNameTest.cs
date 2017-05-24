using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
	[TestClass]
	public class AnimalGroupNameTest
	{
		
		[TestMethod]
		public void GroupHerdTest()
		{
			AnimalGroupName myGroup = new AnimalGroupName();
			Assert.AreEqual("Crash", myGroup.GetHerd("Rhino"));
			Assert.AreEqual("unknown", myGroup.GetHerd("Cat"));
			Assert.AreEqual("Tower", myGroup.GetHerd("Giraffe"));
		}

	}
}
