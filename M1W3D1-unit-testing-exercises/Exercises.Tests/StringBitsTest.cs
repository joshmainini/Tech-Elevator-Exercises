using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
	[TestClass]
	public class StringBitsTest
	{
		[TestMethod]
		public void GetBitsTest()
		{
			StringBits myStringBits = new StringBits();

			Assert.AreEqual("Hlo", myStringBits.GetBits("Hello"));
			Assert.AreEqual("H", myStringBits.GetBits("Hi"));
			Assert.AreEqual("Hello", myStringBits.GetBits("Heeololeo"));

		}
	}
}
