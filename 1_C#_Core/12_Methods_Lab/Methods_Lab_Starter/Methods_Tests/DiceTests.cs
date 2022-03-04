using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(100)]
        [Category("Returns if result correct")]
        public void GivenANumber_PowersRoot_ReturnsCorrectResult(int rndSeed)
        {
            Random test = new Random(rndSeed);
            int dice1 = test.Next(1, 7);
            int dice2 = test.Next(1, 7);
            int result = dice1 + dice2;
            
            Random input = new Random(rndSeed);
            Assert.That(Methods.RollDice(input), Is.EqualTo(result));
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(100)]
        [Category("Returns if result is 1-12")]
        public void GivenANumber_PowersRoot_ReturnWithinRange(int rndSeed)
        {
            Random input = new Random(rndSeed);
            Assert.That(Methods.RollDice(input), Is.InRange(1,12));
            }
    }
}
