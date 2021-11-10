using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial_Converter
{
    public class IC
    {
        public string GetString(string name)
        {
            return name;
        }

        public string[] SplitString(string name)
        {
            string[] BothNames = name.Split(' ');
            return BothNames;
        }

        public string LoopandExtractInitials(string name)
        {
            string[] BothNames = name.Split(' ');
            string FirstName = BothNames[0];
            string SecondName = BothNames[1];

            FirstName.ToCharArray();
            var FirstLetter = FirstName[0].ToString();

            SecondName.ToCharArray();
            var SecondLetter = SecondName[0].ToString();

            return  FirstLetter.ToUpper() +"."+ SecondLetter.ToUpper();
        } 
    }
}
