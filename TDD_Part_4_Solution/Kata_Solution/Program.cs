using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace High_and_Low
{
    namespace Kata_Solution
    {
        class Program
        {
            static void Main(string[] args)
            {
                HighLow obj = new HighLow();               
                Console.WriteLine(obj.GetStringandSort("-50 80 2 5 7 34 56 78 21"));
            }               
        }       
    }
}
