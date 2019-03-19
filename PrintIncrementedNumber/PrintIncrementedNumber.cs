using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintIncrementedNumber
{
    class PrintIncrementedNumber
    {
        public long GetIncrementation(int input)
        {
            if (input < 10) return input + 1;
            long a = input % 10 + 1;
            Console.WriteLine("a: {0}" ,a);
            Console.WriteLine("Input: {0}", input);
            long b = GetIncrementation(input / 10) * 10;
            Console.WriteLine("b: {0}", b);
            return (a == 10) ? ((b + 1) * 10) : (b + a);
        }

        static void Main(string[] args)
        {
            PrintIncrementedNumber solution = new PrintIncrementedNumber();
            Console.WriteLine(solution.GetIncrementation(1245612348));
            Console.ReadKey();
        }
    }
}
