using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class RotateArray
    {
        public void ArrayRotation(int[] nums, int k)
        {
            int count = 0;
            Console.WriteLine(k % nums.Length);

            k = k % nums.Length;
            for (int start = 0; count<nums.Length; start++)
            {
                int curr = start;
                int prev = nums[start];
                do
                {
                    int next = (curr + k) % nums.Length;
                    int temp = nums[next];
                    nums[next] = prev;
                    prev = temp;
                    curr = next;
                    count++;
                } while (start != curr);

            }
            foreach(int value in nums)
            {
                Console.Write(value+",");
            }
        }
        static void Main(string[] args)
        {
            RotateArray solution = new RotateArray();
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] array2 = new int[] { -1, -100, 3, 99 };
            solution.ArrayRotation(array1, 3);
            Console.WriteLine();
            solution.ArrayRotation(array2,2);
            Console.ReadKey();
        }
    }
}
