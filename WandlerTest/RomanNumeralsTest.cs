using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZahlenWandler;

namespace WandlerTest
{
    [TestClass]
    public class RomanNumeralsTest
    {

        private RomanNumerals rn;

        [TestInitialize]
        public void TestInitialize()
        {
            rn = new RomanNumerals();
        }

        [TestMethod]
        public void oneTwoThree()
        {
            Assert.AreEqual("I", rn.convertToRoman(1));
            Assert.AreEqual("II", rn.convertToRoman(2));
            Assert.AreEqual("III", rn.convertToRoman(3));
        }

        [TestMethod]
        public void four()
        {
            Assert.AreEqual("IV", rn.convertToRoman(4));
        }

        [TestMethod]
        public void five()
        {
            Assert.AreEqual("V", rn.convertToRoman(5));
        }

        [TestMethod]
        public void nine()
        {
            Assert.AreEqual("IX", rn.convertToRoman(9));
        }

        [TestMethod]
        public void ten()
        {
            Assert.AreEqual("X", rn.convertToRoman(10));
        }

        [TestMethod]
        public void seventeen()
        {
            Assert.AreEqual("XVII", rn.convertToRoman(17));
        }


        [TestMethod]
        public void twenty()
        {
            Assert.AreEqual("XX", rn.convertToRoman(20));
        }

        [TestMethod]
        public void eightyFour()
        {
            Assert.AreEqual("XLVIII", rn.convertToRoman(48));
        }

        [TestMethod]
        public void ninetyNine()
        {
            Assert.AreEqual("XCIX", rn.convertToRoman(99));
        }

        [TestMethod]
        public void oneHundredNinetyNine()
        {
            Assert.AreEqual("CXCIX", rn.convertToRoman(199));
        }

        [TestMethod]
        public void fiveHundred()
        {
            Assert.AreEqual("D", rn.convertToRoman(500));
        }

        [TestMethod]
        public void sixHundredSixtySix()
        {
            Assert.AreEqual("DCLXVI", rn.convertToRoman(666));
        }

        [TestMethod]
        public void eightHundredAndNinety()
        {
            Assert.AreEqual("DCCCXC", rn.convertToRoman(890));
        }

        [TestMethod]
        public void thousand()
        {
            Assert.AreEqual("M", rn.convertToRoman(1000));
        }

        [TestMethod]
        public void twoThousandFifeHundredTwentySix()
        {
            Assert.AreEqual("MMDXXVI", rn.convertToRoman(2526));
        }
    }
}
