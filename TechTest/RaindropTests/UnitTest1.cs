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

        [TestCase(7, "Plong")]
        [TestCase(14, "Plong")]
        [TestCase(28, "Plong")]
        [TestCase(49, "Plong")]
        public void AFactorOf7IsInput_OutputIsPlong(int input, string result)
        {
            Assert.That(Program.NumConvert(input), Is.EqualTo(result));
        }

        [TestCase(8, "8")]
        [TestCase(13, "13")]
        [TestCase(17, "17")]
        [TestCase(26, "26")]
        public void AnInvalidFactorIs_OutputIsInputNumber(int input, string result)
        {
            Assert.That(Program.NumConvert(input), Is.EqualTo(result));
        }
    }
}