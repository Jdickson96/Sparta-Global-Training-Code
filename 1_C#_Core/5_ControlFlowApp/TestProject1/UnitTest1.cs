using ControlFlowApp;
using NUnit.Framework;


namespace GradeTests
{
    public class OperationTests
    {
      
        [TestCase(64, "Fail")]
        [TestCase(65, "Pass")]
        [TestCase(66, "Pass")]
        [Category("Border Test")]
        public void GivenBorderScore_GetGrade_ReturnsCorrectMessage(int score, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.GetGrade(score)));
        }

        [TestCase(-1, "Fail")]
        [Category("Edge Case")]
        public void GivenEdgeScore_GetGrade_ReturnsCorrectMessage(int score, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.GetGrade(score)));
        }

    }
}