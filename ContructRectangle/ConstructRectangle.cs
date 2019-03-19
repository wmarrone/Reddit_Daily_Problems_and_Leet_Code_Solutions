using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructRectangle
{
    class ConstructRectangle
    {
        public int[] ContructRectangle(int area)
        {
            int w = (int)Math.Sqrt(area);
            while (area % w != 0) { w--; }
            return new int[] {area/w, w};
        }
        static void Main(string[] args)
        {
        }
    }
}
