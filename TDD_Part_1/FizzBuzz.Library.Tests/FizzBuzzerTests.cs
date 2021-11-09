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
        public void Buzzer_WhenDefault_ReturnsInput(
            [Values(1,2,4,7,8,11,13,14,16,17,19)]int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }
        [Test]
        public void Buzzer_WhenDiv3_Return_Fizz(
            [Values(3,6,9,12,18)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_WhenDiv5_ReturnsBuzz(
            [Values(5, 10,20)]int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void Buzzer_WhenDiv3_Div5_Returns_FizzBuzz(
            [Values(15,30,45,60)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
