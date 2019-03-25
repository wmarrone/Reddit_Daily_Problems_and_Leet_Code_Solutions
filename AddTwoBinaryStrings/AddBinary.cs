using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoBinaryStrings
{
    class AddBinary
    {
        static void Main(string[] args)
        {
            String a = "a";
            String b = "b";

            int number1 = Convert.ToInt32(a, 2);
            int number2 = Convert.ToInt32(b, 2);

            Console.WriteLine(Convert.ToString(number1 + number2, 2));
        }
    }
}
