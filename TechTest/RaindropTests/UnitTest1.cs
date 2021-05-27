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

        [TestCase(5, "Plang")]
        [TestCase(10, "Plang")]
        [TestCase(20, "Plang")]
        [TestCase(25, "Plang")]
        public void AFactorOf5IsInput_OutputIsPlang(int input, string result)
        {
            Assert.That(Program.NumConvert(input), Is.EqualTo(result));
        }
    }
}