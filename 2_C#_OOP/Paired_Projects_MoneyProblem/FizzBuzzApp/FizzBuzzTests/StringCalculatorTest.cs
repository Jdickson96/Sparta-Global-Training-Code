using NUnit.Framework;
using FizzBuzzApp;
using System;

namespace FizzBuzzTests
{
    internal class StringCalculatorTest
    {

        [Test]                  //This meets step 1 requirements
        [TestCase("", 0)]
        public void GivenEmptyString_ReturnExpected(string input, int expected)
        {
            Assert.That(StringCalculator.Add(input), Is.EqualTo(expected));
        }

        [Test]                  //This meets step 1 requirements
        [TestCase("1", 1)]
        [TestCase("1,2", 3)]
        public void GivenSimpleString_ReturnExpected(string input, int expected)
        {
            Assert.That(StringCalculator.Add(input), Is.EqualTo(expected));
        }

        [Test]                  //This meets step 2 requirements
        [TestCase("1,2,3,4,5,6,7,8,9", 45)]
        public void GivenLongerString_ReturnExpected(string input, int expected)
        {
            Assert.That(StringCalculator.Add(input), Is.EqualTo(expected));
        }

        [Test]                  //This meets step 3 requirements
        //[Ignore("Step 3")]
        [TestCase("1\n2, 3", 6)]
        public void GivenStringContainingNewLine_ReturnExpected(string input, int expected)
        {
            Assert.That(StringCalculator.Add(input), Is.EqualTo(expected));
        }

        [Test]                  //This meets step 4 requirements
        //[Ignore("Step 4")]
        [TestCase("//;\n1;2", 3)]
        [TestCase("//$\n7$3$2", 12)]
        public void GivenStringCustomisableDelimiters_ReturnExpected(string input, int expected)
        {
            Assert.That(StringCalculator.Add(input), Is.EqualTo(expected));
        }

        [Test]                  //This meets step 5 requirements
        //[Ignore("Step 5")]
        [TestCase("//;\n1;-2", "-2")]
        [TestCase("//;\n-1;-2;5;-4", "-1 -2 -4")]
        public void GivenNegativeDigitsInString_ReturnException(string input, string expected)
        {
            Assert.That(() => StringCalculator.Add(input), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain($"negatives not allowed : {expected}"));
        }

        [Test]                  //This meets step 5 requirements
        //[Ignore("Step 5")]
        [TestCase("//;\n--2;5;4", 11)]
        public void GivenDoubleNegativeDigitInString_ReturnException(string input, int expected)
        {
            Assert.That(StringCalculator.Add(input), Is.EqualTo(expected));
        }

        [Test]                  //This meets step 6 requirements
        //[Ignore("Step 6")]
        [TestCase("//;\n1;2;1001", 3)]
        public void GivenStringWithDigitOverThousand_ReturnSumIgnoringOverThousandDigit(string input, int expected)
        {
            Assert.That(StringCalculator.Add(input), Is.EqualTo(expected));
        }

        [Test]                  //This meets step 7 requirements
        //[Ignore("Step 7")]
        [TestCase("//[***]\n1***2***3", 6)]
        public void GivenMultipleCharDelimiter_ReturnExpected(string input, int expected)
        {
            Assert.That(StringCalculator.Add(input), Is.EqualTo(expected));
        }

        [Test]                  //This meets step 8 requirements
        //[Ignore("Step 8")]
        [TestCase("//[*][%]\n1*2%3", 6)]
        public void GivenMoreThanOneDelimiter_ReturnExpected(string input, int expected)
        {
            Assert.That(StringCalculator.Add(input), Is.EqualTo(expected));
        }

        [Test]                  //This meets step 9 requirements
        //[Ignore("Step 9")]
        [TestCase("//[***][%%%]\n1***2%%%3", 6)]
        [TestCase("//[***][%%%][$$$]\n1***2%%%3$$$4", 10)]
        public void GivenMoreThanOneMultipleCharDelimiter_ReturnExpected(string input, int expected)
        {
            Assert.That(StringCalculator.Add(input), Is.EqualTo(expected));
        }
    }
}
