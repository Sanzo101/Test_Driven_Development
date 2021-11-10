using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_and_Low
{
    public class HighLow
    {
        public string GetStringandSort(string numbers)
        {
            var parsed = numbers.Split().Select(int.Parse);
            return parsed.Max() + " " + parsed.Min();
        }
    }
}
