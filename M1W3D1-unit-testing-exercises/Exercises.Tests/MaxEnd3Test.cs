using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
	[TestClass]
	public class MaxEnd3Test
	{
		[TestMethod]
		public void MakeArrayTest()
		{
			MaxEnd3 myMaxEnd3 = new MaxEnd3();
			CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, myMaxEnd3.MakeArray(new int[] { 1, 2, 3 }));
			CollectionAssert.AreEqual(new int[] { 11,11,11 }, myMaxEnd3.MakeArray(new int[] { 11, 5, 9 }));
			CollectionAssert.AreEqual(new int[] { 3,3,3 }, myMaxEnd3.MakeArray(new int[] { 2,11,3 }));
		}
	}
}
