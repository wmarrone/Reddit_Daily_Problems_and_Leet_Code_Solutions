using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_sTriangle
{
    class PascalsTriangle
    {
        public List<List<int>> Generate(int numRows)
        {
            List<List<int>> pascalsTriangle = new List<List<int>>();
            int rowCount = 0;
            List<int> sampleList = new List<int>();
            while (pascalsTriangle.Count < numRows)
            {
                if (rowCount == 0) { sampleList.Add(1); }
                else if(rowCount == 1) { sampleList = new List<int>(pascalsTriangle[pascalsTriangle.Count - 1]); sampleList.Add(1);}
                else
                {
                    sampleList = new List<int>(pascalsTriangle[1]);
                    
                    for(int x = 1; x<=rowCount-1; x++)
                    {
                        sampleList.Insert(x, pascalsTriangle[rowCount-1][x - 1] + pascalsTriangle[rowCount-1][x]);
                    }
                }
                pascalsTriangle.Add(sampleList);
                rowCount++;
            }
            foreach (List<int> list in pascalsTriangle)
            {
                Display(list);
            }
            return pascalsTriangle;
        }
        static void Display(List<int> List)
        {
            foreach(int i in List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            PascalsTriangle pt = new PascalsTriangle();
            pt.Generate(5);
            Console.ReadKey();
        }
    }
}
