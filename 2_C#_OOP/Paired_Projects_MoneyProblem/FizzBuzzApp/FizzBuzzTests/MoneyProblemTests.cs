using NUnit.Framework;
using FizzBuzzApp;

namespace FizzBuzzTests
{
    public class MoneyProblemTests
    {
        [TestCase(3.61, "- 1 `£2`\n- 1 `£1`\n- 1 `50p`\n- 1 `10p`\n- 1 `1p`")]
        [TestCase(5.47, "- 1 `£5`\n- 2 `20p`\n- 1 `5p`\n- 1 `2p`")]
        [TestCase(12.58, "- 1 `£10`\n- 1 `£2`\n- 1 `50p`\n- 1 `5p`\n- 1 `2p`\n- 1 `1p`")]
        [TestCase(37.73, "- 1 `£20`\n- 1 `£10`\n- 1 `£5`\n- 1 `£2`\n- 1 `50p`\n- 1 `20p`\n- 1 `2p`")]
        [TestCase(64.55, "- 1 `£50`\n- 1 `£10`\n- 2 `£2`\n- 1 `50p`\n- 1 `5p`")]
        [TestCase(99.99, "- 1 `£50`\n- 2 `£20`\n- 1 `£5`\n- 2 `£2`\n- 1 `50p`\n- 2 `20p`\n- 1 `5p`\n- 2 `2p`")]
        [Description("Testing The Money bills & coins converter")]
        public void GivenAValue_ReturnCorrectMoney(double input, string expected)
        {
            var result = MoneyProblem.BillConverter(input);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
