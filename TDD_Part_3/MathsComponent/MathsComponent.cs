using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Simple KATA practice
namespace MathsComponentNameSpace
{
    public class MathsComponent
    {
        public int Add(int num1, int num2)
        {
            return num1+num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Squared(int num1)
        {
            int result = num1 * num1;
            return result;
        }

        public int AddSquared(int Square1, int Square2)
        {
            Square1 = Squared(Square1);
            Square2 = Squared(Square2);
            int result = Add(Square1, Square2);
            return result;
        }

        public int SquaredSum(int[] num)
        {
            int sum = 0;
            foreach(int i in num)
            {
                int a = Squared(i);
                sum += a;
            }
            return sum;
        }

        public int Input(int num)
        {          
            return num;
        }

        public int[] InputArray(int[] numbers)
        {
            return numbers;
        }

        public int[] SortArray(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        public int[] DescendingArray(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            return numbers;
        }
        public int CreateHighestPossibleNumber(int num)
        {
            char[] arr = num.ToString().ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            return Convert.ToInt32(new string(arr));
        }
    }
}
