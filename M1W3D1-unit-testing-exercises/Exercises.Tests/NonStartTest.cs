using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
	[TestClass]
	public class NonStartTest
	{
		[TestMethod]
		public void GetPartialStringTest()
		{
			NonStart myNonStart = new NonStart();

			Assert.AreEqual("ellohere", myNonStart.GetPartialString("Hello", "There"));
			Assert.AreEqual("avaode", myNonStart.GetPartialString("java", "code"));
			Assert.AreEqual("hotlava", myNonStart.GetPartialString("Shotl", "java"));

		}
	}
}
