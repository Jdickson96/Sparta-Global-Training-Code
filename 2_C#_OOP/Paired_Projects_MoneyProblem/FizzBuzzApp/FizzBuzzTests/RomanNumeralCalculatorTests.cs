using NUnit.Framework;
using FizzBuzzApp;
using System;

namespace FizzBuzzTests
{
    public class RomanNumeralCalculatorTests
    {
        [Test]
        [Description("Trying a negative number")]
        public void GivenNegativeNumber_ThrowCorrectError()
        {
            Assert.That(() => RomanNumeralCalculator.NumToRomanNumConverter(-2), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("The Roman numeral system doesn't have a negative number system."));
        }

        [Test]
        [Description("Trying number 0")]
        public void GivenZero_ThrowCorrectError()
        {
            Assert.That(() => RomanNumeralCalculator.NumToRomanNumConverter(0), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("There is no Roman numeral for 0."));
        }


        [TestCase(1, "I")]
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(12, "XII")]
        [TestCase(34, "XXXIV")]
        [TestCase(44, "XLIV")]
        [TestCase(49, "XLIX")]
        [TestCase(99, "XCIX")]
        [TestCase(124, "CXXIV")]
        [TestCase(149, "CXLIX")]
        [TestCase(222, "CCXXII")]
        [TestCase(444, "CDXLIV")]
        [TestCase(555, "DLV")]
        [TestCase(987, "CMLXXXVII")]
        [TestCase(1111, "MCXI")]
        [TestCase(1371, "MCCCLXXI")]
        [TestCase(2688, "MMDCLXXXVIII")]
        [TestCase(3848, "MMMDCCCXLVIII")]
        [Description("Testing The Roman Calculator")]
        public void GivenANumber_ReturnTheCorrectRomanNumeral(int input, string expected)
        {
            var result = RomanNumeralCalculator.NumToRomanNumConverter(input);
            Assert.That(expected, Is.EqualTo(result));

        }

    }
}
