using CodeToTest;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [Category("In Range cases")]
        [TestCase(7, "U, PG films are available.")]
        [TestCase(10, "U, PG films are available.")]
        [TestCase(13, "U, PG & 12 films are available.")]
        [TestCase(14, "U, PG & 12 films are available.")]
        [TestCase(16, "U, PG, 12 & 15 films are available.")]
        [TestCase(17, "U, PG, 12 & 15 films are available.")]
        [TestCase(20, "All films are available.")]
        [TestCase(34, "All films are available.")]
        public void GivenAnInRangeAge_Rating_ReturnsCorrectMessage(int ageOfViewer, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.AvailableClassifications(ageOfViewer)));
        }


        [Category("Edge cases")]
        [TestCase(12, "U, PG & 12 films are available.")]
        [TestCase(15, "U, PG, 12 & 15 films are available.")]
        [TestCase(18, "All films are available.")]
        public void GivenAnEdgeAge_Rating_ReturnsCorrectMessage(int ageOfViewer, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.AvailableClassifications(ageOfViewer)));
        }

        [Category("Exception Tests")]
        [TestCase(-1)]
        [TestCase(175)]
        public void GivenAnOutOfRangeAge_Rating_ReturnsException(int ageOfViewer)
        {
            Assert.That(() => Program.AvailableClassifications(ageOfViewer), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("ageOfViewer: " + ageOfViewer + " " + "Allowed range 0-150"));
        }
    }
}