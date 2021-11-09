using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MathsComponentNameSpace
{
   public class MathsComponenetTester
   {
        [Test]
      public void When_Two_Numbers_Are_Added()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }
        [Test]
      public void When_Two_Numbers_Are_Subtracted()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }
        [Test]
      public void When_Two_Numbers_Are_Multiplied()
        {
            //Arrange
            MathsComponent obj = new MathsComponent();
            //Act
            int result = obj.Multiply(2, 2);
            //Assert
            Assert.AreEqual(4, result);
        }
        [Test]
        public void When_Two_Numbers_Are_Divided()
        {
            //Arrange
            MathsComponent obj = new MathsComponent();
            //Act
            int result = obj.Divide(2, 2);
            //Assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void Should_Square_Any_Number()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Squared(10);
            Assert.AreEqual(100, result);
        }
        [Test]
        public void Should_Add_Squared_Numbers()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.AddSquared(4,3);
            Assert.AreEqual(25, result);
        }
        [Test]
        public void Squares_and_Adds_All_The_Number_In_The_Array()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.SquaredSum(new int[] {1,2,3});
            Assert.AreEqual(14, result);
        }
        [Test]
        public void Receives_Number()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Input(464556745);
            Assert.AreEqual(464556745, result);
        }
        [Test]
        public void Receive_Array_Of_Numbers()
        {
            MathsComponent obj = new MathsComponent();
            int[] result = obj.InputArray(new int[]{ 1, 2, 3, 8 });
            Assert.AreEqual(new int[]{ 1, 2, 3, 8 }, result);
        }
        [Test]
        public void Should_Sort_Numbers_In_Order()
        {
            MathsComponent obj = new MathsComponent();
            int[] result = obj.SortArray(new int[] { 2, 1, 5, 4 });
            Assert.AreEqual(new int[] { 1, 2, 4, 5 }, result);
        }
        [Test]
        public void Should_Sort_Numbers_Descending()
        {
            MathsComponent obj = new MathsComponent();
            int[] result = obj.DescendingArray(new int[] { 2, 1, 5, 4 });
            Assert.AreEqual(new int[] { 5,4,2,1 }, result);
        }
        [Test]
        public void Should_Return_Any_Number_Descending_From_Highest_To_Lowest()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.CreateHighestPossibleNumber(123456789);
            Assert.AreEqual(987654321, result);
        }
    }
}
