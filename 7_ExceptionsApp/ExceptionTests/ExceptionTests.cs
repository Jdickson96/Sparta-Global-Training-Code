using ExceptionsApp;
using NUnit.Framework;
using System;
using static ExceptionsApp.Program;

namespace ExceptionTests
{
    public class GradeTests
    {
        [TestCase(-34)]
        [TestCase(-1)]
        [Category("Less Than Zero")]
        public void WhenMarkLessThanZero_Grade_ThrowsArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<GradeException>()
                .With.Message.Contain("Allowed range 0-100"));
        }
    }
}