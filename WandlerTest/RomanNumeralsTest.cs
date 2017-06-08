using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZahlenWandler;

namespace WandlerTest
{
    [TestClass]
    public class RomanNumeralsTest
    {
        //[TestInitialize]
        //public void TestInitialize()
        //{
        //    rn = new RomanNumerals();
        //}

        [TestMethod]
        public void oneTwoThree()
        {
            Assert.AreEqual("I", RomanNumerals.convertToRoman(1));
            Assert.AreEqual("II", RomanNumerals.convertToRoman(2));
            Assert.AreEqual("III", RomanNumerals.convertToRoman(3));
        }

        [TestMethod]
        public void four()
        {
            Assert.AreEqual("IV", RomanNumerals.convertToRoman(4));
        }

        [TestMethod]
        public void five()
        {
            Assert.AreEqual("V", RomanNumerals.convertToRoman(5));
        }

        [TestMethod]
        public void nine()
        {
            Assert.AreEqual("IX", RomanNumerals.convertToRoman(9));
        }

        [TestMethod]
        public void ten()
        {
            Assert.AreEqual("X", RomanNumerals.convertToRoman(10));
        }

        [TestMethod]
        public void seventeen()
        {
            Assert.AreEqual("XVII", RomanNumerals.convertToRoman(17));
        }


        [TestMethod]
        public void twenty()
        {
            Assert.AreEqual("XX", RomanNumerals.convertToRoman(20));
        }

        [TestMethod]
        public void eightyFour()
        {
            Assert.AreEqual("XLVIII", RomanNumerals.convertToRoman(48));
        }

        [TestMethod]
        public void ninetyNine()
        {
            Assert.AreEqual("XCIX", RomanNumerals.convertToRoman(99));
        }

        [TestMethod]
        public void oneHundredNinetyNine()
        {
            Assert.AreEqual("CXCIX", RomanNumerals.convertToRoman(199));
        }

        [TestMethod]
        public void fourHundredEightyNine()
        {
            Assert.AreEqual("CDLXXXIX", RomanNumerals.convertToRoman(489));
        }

        [TestMethod]
        public void fiveHundred()
        {
            Assert.AreEqual("D", RomanNumerals.convertToRoman(500));
        }

        [TestMethod]
        public void sixHundredSixtySix()
        {
            Assert.AreEqual("DCLXVI", RomanNumerals.convertToRoman(666));
        }

        [TestMethod]
        public void eightHundredAndNinety()
        {
            Assert.AreEqual("DCCCXC", RomanNumerals.convertToRoman(890));
        }

        [TestMethod]
        public void thousand()
        {
            Assert.AreEqual("M", RomanNumerals.convertToRoman(1000));
        }

        [TestMethod]
        public void twoThousandFifeHundredTwentySix()
        {
            Assert.AreEqual("MMDXXVI", RomanNumerals.convertToRoman(2526));
        }

        [TestMethod]
        public void romanTen()
        {
            Assert.AreEqual(10 , RomanNumerals.convertToArabic("X"));
        }

        [TestMethod]
        public void romanFifteen()
        {
            Assert.AreEqual(15, RomanNumerals.convertToArabic("XV"));
        }

        [TestMethod]
        public void romanFourtyEight()
        {
            Assert.AreEqual(48, RomanNumerals.convertToArabic("XLVIII"));
        }

    }
}
