using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighandLow
{
    public class HighLow
    {
        public int Number_Input(int number)
        {
            return number;
        }

        public string String_Input(string word)
        {
            return word;
        }

        public char[] ArrayConverter(string word)
        {
            char[] Arr = word.ToCharArray();
            return Arr;
        }

        public char[] RemovesWhiteSpace(string word)
        {
            string trimmed = String.Concat(word.Where(c => !Char.IsWhiteSpace(c)));
            char[] Arr = trimmed.ToCharArray();
            return Arr;
        }

        public char[] SortString(string word)
        {
            string trimmed = String.Concat(word.Where(c => !Char.IsWhiteSpace(c)));
            char[] Arr = trimmed.ToCharArray();
            Array.Sort(Arr);
            return Arr;
        }

        public char[] GetHighandLow(string word)
        {
            string trimmed = String.Concat(word.Where(c => !Char.IsWhiteSpace(c)));
            char[] Arr = trimmed.ToCharArray();
            Array.Sort(Arr);
            char[] HighestandLowest = { Arr[0], Arr[Arr.Length-1] };
            return HighestandLowest;
        }
        public char[] GetHighandLowReturnWhiteSpace(string word)
        {
            string trimmed = String.Concat(word.Where(c => !Char.IsWhiteSpace(c)));
            char[] Arr = trimmed.ToCharArray();
            Array.Sort(Arr);
            char[] HighestandLowest = { Arr[0],' ', Arr[Arr.Length - 1] };
            return HighestandLowest;
        }
        public string ConvertToString(string word)
        {
            string trimmed = String.Concat(word.Where(c => !Char.IsWhiteSpace(c)));
            char[] Arr = trimmed.ToCharArray();
            Array.Sort(Arr);
            char[] HighestandLowest = { Arr[0],' ', Arr[Arr.Length - 1] };
            string output = new string(HighestandLowest);
            return output;
        }
    }
}
