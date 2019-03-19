using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintIncrementedNumber
{
    class Additive_Persistance
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"addative persistence: {getAdditivePersistence(13)}"); // -> 1
            Console.WriteLine($"addative persistence: {getAdditivePersistence(1234)}"); // -> 2
            Console.WriteLine($"addative persistence: {getAdditivePersistence(9876)}"); // -> 2
            Console.WriteLine($"addative persistence: {getAdditivePersistence(199)}"); // -> 3
            Console.ReadKey();
        }

        public static int getAdditivePersistence(int num)
        {
            var counter = 0;
            while (num >= 10)
            {
                num = AddDigits(num);
                counter++;
            }
            return counter;
        }

        public static int AddDigits(int num)
        {
            var total = 0;
            while (num != 0)
            {
                total += num % 10;
                num = num / 10;
            };
            return total;
        }
    }
}
