using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_3DPoint
{
    struct _3DPoint
    {
        public int x;
        public int y;
        public int z;

        public _3DPoint(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }

        public double DistanceFromOrigin()
        {
            return Math.Pow(x ^ 2 + y ^ 2 + z ^ 2, 1/2);
        }

        public double DistanceBetween2Points(_3DPoint point)
        {
            return Math.Pow((x - point.x) ^ 2 + (y - point.y) ^ 2 + (z - point.z) ^ 2, 1/2);
        }

        public double ScalarProduct(_3DPoint point)
        {
            return x * point.x + y * point.y + z * point.z;
        }

    }
}
