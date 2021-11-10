using System;
namespace Initial_Converter
{
    namespace Kata_Attempt
    {
        class Program
        {          
            static void Main(string[] args)
            {
                IC NameConverter = new IC();
                Console.WriteLine(NameConverter.LoopandExtractInitials("san busnaina"));
            }
        }
    }
}
