using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
	[TestClass]
	public class CigarPartyTest
	{
		[TestMethod]
		public void HavePartyTest()
		{
			CigarParty myCigarParty = new CigarParty();
			Assert.AreEqual(false, myCigarParty.HaveParty(30, false));
			Assert.AreEqual(true, myCigarParty.HaveParty(50, true));
			Assert.AreEqual(true, myCigarParty.HaveParty(70, true));

		}
	}
}
