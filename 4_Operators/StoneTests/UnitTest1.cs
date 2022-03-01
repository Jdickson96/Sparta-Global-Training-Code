using Operators;
using NUnit.Framework;
using System;


namespace StoneTests
{
    public class OperatorTests
    {
        //Stone No Test

        [TestCase(0, 0)]
        [TestCase(13, 0)]
        [TestCase(14, 1)]
        [TestCase(15, 1)]
        [TestCase(140, 10)]
        [Category("Stones Tests")]
        public void GivenPounds_GetStones_ReturnsCorrectValue(int totalPounds, int expected)
        {
            Assert.That(expected, Is.EqualTo(Methods.GetStones(totalPounds)));
        }

        [Category("Exception Tests")]
        [TestCase(-1)]
        public void GivenPounds_GetStones_ReturnsException(int totalPounds)
        {
            Assert.That(() => Methods.GetStones(totalPounds), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("totalPounds: " + totalPounds + " Value Must Be Greater than Zero"));
        }

        //Pound No Test

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(13, 13)]
        [TestCase(14, 0)]
        [TestCase(15, 1)]
        [TestCase(141, 1)]
        [Category("Pounds Tests")]
        public void GivenPounds_GetPounds_ReturnsCorrectValue(int totalPounds, int expected)
        {
            Assert.That(expected, Is.EqualTo(Methods.GetPounds(totalPounds)));
        }

        [Category("Exception Tests")]
        [TestCase(-1)]
        public void GivenPounds_GetPounds_ReturnsException(int totalPounds)
        {
            Assert.That(() => Methods.GetPounds(totalPounds), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("totalPounds: " + totalPounds + " Value Must Be Greater than Zero"));
        }

    }
}
