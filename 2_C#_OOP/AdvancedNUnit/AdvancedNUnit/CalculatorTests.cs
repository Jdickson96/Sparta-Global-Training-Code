using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedNUnit
{
    [TestFixture(1,3)]
    public class CalculatorTests
    {

        [SetUp]
        public void Setup() { }

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        [Test]
        public void SomeConstriants()
        {
            var subject = new Calculator { Num1 = 6 };
            Assert.That(subject.DivisibleBy3());
            subject = new Calculator { Num1 = 7 };
            Assert.That(subject.DivisibleBy3(), Is.False);
            Assert.That(subject.ToString(), Does.Contain("Calculator"));
        }

        [Test]
        public void StringConstriants()
        {
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            var strResult = subject.ToString();
            Assert.That(strResult, Does.Contain("Calculator"));
            Assert.That(strResult, Does.Not.Contain("Potato"));
            Assert.That(strResult, Is.Not.Empty);
            Assert.That(strResult, Is.EqualTo("advancedunit.calculator").IgnoreCase);
        }

        [Test]
        public void TestListOfStrings()
        {
            var fruits = new List<string>
            {
                "apple", "pear", "banana", "peach"
            };

            Assert.That(fruits, Does.Contain("pear"));
            Assert.That(fruits, Has.Count.EqualTo(4));
            Assert.That(fruits, Has.Exactly(2).StartsWith("pea"));
        }

        [Ignore("Will fail")]
        [Test]
        public void TestList_Classic()
        {
            var myList = new List<int>
            {
                1,2,3
            };

            Assert.AreEqual(1, myList.Where(x => x ==4).Count());
        }

        [Ignore("Will fail")]
        [Test]
        public void TestList_ConstraintModel()
        {
            var myList = new List<int>
            {
                1,2,3
            };

            Assert.That(myList, Has.Exactly(1).EqualTo(4));
        }

        [Test]
        public void TestRange()
        {
            Assert.That(8, Is.InRange(1, 10));
            var myList = new List<int>
            {
                4,2,7,5,9
            };
            Assert.That(myList, Is.All.InRange(1, 10));
            Assert.That(myList, Has.Exactly(3).InRange(1, 5));
        }

        [TestCase(2,4,6)]
        [TestCase(-2,3,1)]
        [TestCaseSource("AddCases")]

        public void Add_Always_Returns_ExpectedResult(int x, int y, int expected)
        {
            var subject = new Calculator { Num1 = x, Num2 = y };
            Assert.That(subject.Add(), Is.EqualTo(expected));
        }

        private static object[] AddCases =
        {
            new int[] {2,4,6},
            new int[] {-2,3,1}
        };
    }
}