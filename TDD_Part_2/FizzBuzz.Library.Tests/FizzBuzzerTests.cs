using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void WhenDefault_RetrunsInput(
            [Values(1,2,4,7,8,11,13,14,16,17,19)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }
        [Test]
        public void WhenDiv3_ReturnFizz(
            [Values(3,6,9,12,18)]int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void WhenDiv5_ReturnFizz_Buzz(
            [Values(5,10,20)]int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void When_Div3_Div5_Returns_FizzBuzz(
            [Values(15)]int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
