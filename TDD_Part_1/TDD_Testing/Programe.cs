using NUnit.Framework;
using System;
using FizzBuzz.Library;

namespace TDD_Testing
{
    class Programe
    {
        static void main(string[] args)
        {
            for (int i = 1;i <= 100;i++)
            {
                Console.WriteLine(FizzBuzzer.GetValue(i));
                Console.ReadLine();
            }
              
        }
    }
}