using NUnit.Framework;
using TechTest;

namespace RaindropTests
{
    public class Tests
    {
        [TestCase(3, "Pling")]
        [TestCase(6, "Pling")]
        [TestCase(9, "Pling")]
        [TestCase(12, "Pling")]
        public void AFactorOf3IsInput_OutputIsPling(int input, string result)
        {
            Assert.That(Program.NumConvert(input), Is.EqualTo(result));
        }
    }
}