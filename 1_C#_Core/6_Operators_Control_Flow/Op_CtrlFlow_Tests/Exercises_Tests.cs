using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;
using System;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // Unit test(s) for MyMethod
        [Test]
        [TestCase(10,10, false)]
        [TestCase(15, 15, false)]
        [TestCase(20, 20, false)]
        [Category("Both Numbers are Equal")]
        public void WhenNumbersTheSame_MyMethod_ReturnsFalse(int num1, int num2, bool expected)
        {
            Assert.That(Exercises.MyMethod(num1,num2), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(20, 10, true)]
        [TestCase(15, 5, true)]
        [TestCase(200, 20, true)]
        [Category("Number 1 is Divisible by Number 2")]
        public void WhenNum1Divisible_MyMethod_ReturnsTrue(int num1, int num2, bool expected)
        {
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10, 20, false)]
        [TestCase(5, 15, false)]
        [TestCase(7, 2, false)]
        [Category("Failure Tests")]
        public void WhenNum1IsNotDivisible_MyMethod_ReturnsFalse(int num1, int num2, bool expected)
        {
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(expected));
        }


        // Unit test(s) for Average
        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsException()
        {
            var myList = new List<int>() {};
            Assert.That(() => Exercises.Average(myList), Throws.TypeOf<NullReferenceException>()
                .With.Message.Contain("Average Cannot Be Calculated From Empty Array"));
        }

        // Unit test(s) for TicketType

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void GivenAnAge_TicketType_ReturnsCorrect(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Category("Exception Tests")]
        [TestCase(-1)]
        [TestCase(175)]
        public void GivenAnAge_TicketType_ReturnsException(int age)
        {
            Assert.That(() => Exercises.TicketType(age), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("age: " + age + " Allowed range 0-150"));
        }

        // Unit test(s) for Grade

        [Test]
        [TestCase(0,  "Fail")]
        [TestCase(39, "Fail")]
        [TestCase(40, "Pass")]
        [TestCase(59, "Pass")]
        [TestCase(60, "Pass with Merit")]
        [TestCase(74, "Pass with Merit")]
        [TestCase(75, "Pass with Distinction")]
        [TestCase(100, "Pass with Distinction")]
        [Category("Edge Cases")]
        public void WhenScoreIsEdgeCase_Grade_ReturnsCorrect(int score, string expected)
        {
            Assert.That(Exercises.Grade(score), Is.EqualTo(expected));
        }

        [Category("Exception Tests")]
        [TestCase(-1)]
        [TestCase(101)]
        public void GivenAScore_Grade_ReturnsException(int score)
        {
            Assert.That(() => Exercises.Grade(score), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("mark: " + score + " Allowed range 0-100"));
        }

        // Unit test(s) for Scottish Weddings

        [Test]
        [TestCase(0, 200)]
        [TestCase(1, 100)]
        [TestCase(2, 50)]
        [TestCase(3, 50)]
        [TestCase(4, 20)]
        [Category("Scottish Covid Restrictions")]
        public void WhenLevel_Attendees_ReturnsCorrect(int level, int expected)
        {
            Assert.That(Exercises.GetScottishMaxWeddingNumbers(level), Is.EqualTo(expected));
        }

        [Category("Exception Tests")]
        [TestCase(-1)]
        [TestCase(5)]
        public void WhenLevel_Attendees_ReturnsException(int level)
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(level), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("level: " + level + " Allowed range 0-4"));
        }

    }
}
