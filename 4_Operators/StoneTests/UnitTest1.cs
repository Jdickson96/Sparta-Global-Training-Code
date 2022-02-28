using Operators;
using NUnit.Framework;


namespace StoneTests
{
    public class OperatorTests
    {
        [TestCase(-1, 0)]
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

        [TestCase(-1, -1)]
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

    }
}
