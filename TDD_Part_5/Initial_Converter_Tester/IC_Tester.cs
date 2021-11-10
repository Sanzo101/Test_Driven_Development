using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Initial_Converter
{
    public class IC_Tester
    {
        [Test]
        public void Takes_a_String_Input()
        {
            IC obj = new IC();
            string result = obj.GetString("Sam Harris");
            Assert.AreEqual("Sam Harris", result);
        }
        [Test]
        public void Split_String_In_two()
        {
            IC obj = new IC();
            string[] result = obj.SplitString("Sam Harris");
            Assert.AreEqual(new string[] { "Sam", "Harris" }, result);
        }
        [Test]
        public void Get_First_Letter_of_Each_String()
        {
            IC obj = new IC();
            string result = obj.LoopandExtractInitials("sam harris");
            Assert.AreEqual("S.H", result);
        }
    }
}
