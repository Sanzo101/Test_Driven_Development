using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace High_and_Low
{
    public class HighLowTester
    {
        //Arrange
        HighLow obj = new HighLow();
        [Test]
        public void Takes_In_A_String()
        {
            //Act
            string result = obj.GetStringandSort("3 -2 4 6 5");
            //Assert
            Assert.AreEqual("6 -2", result);
        }
    }
}
