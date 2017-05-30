using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
     [TestMethod]
	 public void ConvertToRomanNumeralTest_I()
		{
			KataRomanNumerals romanNumerals = new KataRomanNumerals();

			Assert.AreEqual("I", romanNumerals.ConvertToRomanNumeral(1));

		}


		[TestMethod]
		public void ConvertToRomanNumeralTest_V()
		{
			KataRomanNumerals romanNumerals = new KataRomanNumerals();

			Assert.AreEqual("V", romanNumerals.ConvertToRomanNumeral(5));

		}

		[TestMethod]
		public void ConvertToRomanNumeralTest_IV()
		{
			KataRomanNumerals romanNumerals = new KataRomanNumerals();

			Assert.AreEqual("IX", romanNumerals.ConvertToRomanNumeral(9));

		}

		[TestMethod]
		public void ConvertToRomanNumeralTest_IX()
		{
			KataRomanNumerals romanNumerals = new KataRomanNumerals();

			Assert.AreEqual("IX", romanNumerals.ConvertToRomanNumeral(9));

		}

		[TestMethod]
		public void ConvertToRomanNumeralTest_CDL()
		{
			KataRomanNumerals romanNumerals = new KataRomanNumerals();

			Assert.AreEqual("CDL", romanNumerals.ConvertToRomanNumeral(450));

		}

		[TestMethod]
		public void ConvertToRomanNumeralTest_MMDC()
		{
			KataRomanNumerals romanNumerals = new KataRomanNumerals();

			Assert.AreEqual("MMDC", romanNumerals.ConvertToRomanNumeral(2600));

		}

		[TestMethod]
		public void ConvertToDigit_1()
		{
			KataRomanNumerals romanNumerals = new KataRomanNumerals();

			Assert.AreEqual(1, romanNumerals.ConvertToDigit("I"));

		}


		[TestMethod]
		public void ConvertToDigit_10()
		{
			KataRomanNumerals romanNumerals = new KataRomanNumerals();

			Assert.AreEqual(10, romanNumerals.ConvertToDigit("X"));

		}


		[TestMethod]
		public void ConvertToDigit_9()
		{
			KataRomanNumerals romanNumerals = new KataRomanNumerals();

			Assert.AreEqual(9, romanNumerals.ConvertToDigit("IX"));

		}

	}
}
