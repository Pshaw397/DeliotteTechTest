using NUnit.Framework;
using TechTest;

namespace RaindropTests
{
    public class TestFramework
    {
        // This test checks if "Pling" is returned when the input number is a factor of 3 and not of 5 or 7
        [TestCase(3, "Pling")]
        [TestCase(6, "Pling")]
        [TestCase(9, "Pling")]
        [TestCase(12, "Pling")]
        public void AFactorOf3IsInput_OutputIsPling(int input, string result)
        {
            Assert.That(Program.NumConvert(input), Is.EqualTo(result));
        }

        // This test checks if "Plang" is returned when the input number is a factor of 5 and not of 3 or 7
        [TestCase(5, "Plang")]
        [TestCase(10, "Plang")]
        [TestCase(20, "Plang")]
        [TestCase(25, "Plang")]
        public void AFactorOf5IsInput_OutputIsPlang(int input, string result)
        {
            Assert.That(Program.NumConvert(input), Is.EqualTo(result));
        }

        // This test checks if "Plong" is returned when the input number is a factor of 7 and not of 5 or 3
        [TestCase(7, "Plong")]
        [TestCase(14, "Plong")]
        [TestCase(28, "Plong")]
        [TestCase(49, "Plong")]
        public void AFactorOf7IsInput_OutputIsPlong(int input, string result)
        {
            Assert.That(Program.NumConvert(input), Is.EqualTo(result));
        }

        // This test checks if the number input is returned when the input number is not a factor of 3, 5 or 7
        [TestCase(8, "8")]
        [TestCase(13, "13")]
        [TestCase(17, "17")]
        [TestCase(26, "26")]
        public void AnInvalidFactorIs_OutputIsInputNumber(int input, string result)
        {
            Assert.That(Program.NumConvert(input), Is.EqualTo(result));
        }

        // This test checks if the correct string is returned if a number that is a factor or 2 possible numbers is input
        [TestCase(30, "PlingPlang")]
        [TestCase(70, "PlangPlong")]
        [TestCase(21, "PlingPlong")]
        [TestCase(35, "PlangPlong")]
        public void AFactorOf2NumbersIsInput_OutputIsTheCombinationOfValidFactorWords(int input, string result)
        {
            Assert.That(Program.NumConvert(input), Is.EqualTo(result));
        }
    }
}