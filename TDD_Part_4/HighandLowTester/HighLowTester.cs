using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HighandLow
{   
    public class HighLowTester
    {
        [Test]
        public void Takes_In_A_number()
        {
            //ARRANGE
            HighLow obj = new HighLow();
            //ACT
            int result = obj.Number_Input(10);
            //ASSERT
            Assert.AreEqual(10, result);
        }
        [Test]
        public void Takes_In_String()
        {
            HighLow obj = new HighLow();
            string result = obj.String_Input("10 12 14 15 16");
            Assert.AreEqual("10 12 14 15 16", result);
        }
        [Test]
        public void Converts_String_to_Char_Array()
        {
            HighLow obj = new HighLow();
            char[] result = obj.ArrayConverter("245");
            Assert.AreEqual(new char[] { '2', '4', '5'}, result);
        }
        [Test]
        public void Removing_Spaces_From_Strings()
        {
            HighLow obj = new HighLow();
            char[] result = obj.RemovesWhiteSpace("3 1 2");
            Assert.AreEqual(new char[] { '3', '1', '2' }, result);
        }
        [Test]
        public void Arranges_String_In_Order()
        {
            HighLow obj = new HighLow();
            char[] result = obj.SortString("3 1 2");
            Assert.AreEqual(new char[] { '1', '2', '3' }, result);
        }
        [Test]
        public void Should_Eliminate_All_Num_Except_High_and_Low()
        {
            HighLow obj = new HighLow();
            char[] result = obj.GetHighandLow("3 1 2 4 6 7 3 9");
            Assert.AreEqual(new char[] { '1', '9' }, result);
        }
        [Test]
        public void AddingSpaceBack()
        {
            HighLow obj = new HighLow();
            char[] result = obj.GetHighandLowReturnWhiteSpace("3 1 2 4 6 7 3 9");
            Assert.AreEqual(new char[] { '1',' ', '9' }, result);
        }
        [Test]
        public void Convert_to_String()
        {
            HighLow obj = new HighLow();
            string result = obj.ConvertToString("3 1 2 4 6 7 3 9 3 5 6 3 2 4");
            Assert.AreEqual("1 9", result);
        }
    }
}
