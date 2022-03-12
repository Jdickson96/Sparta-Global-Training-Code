using NUnit.Framework;
using FizzBuzzApp;

namespace TestProject1
{
    public class FizzBuzzShould
    {
        [Test]
        public void GiveOne_Return_OneString()
        {
            Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void GivenANumberDivisibleByThree_Return_Fizz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Fizz"));
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void GivenANumberDivisibleByFive_Return_Buzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Buzz"));
        }
        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void GivenANumberDivisibleByFifteen_Return_FizzBuzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("FizzBuzz"));
        }
    }
}