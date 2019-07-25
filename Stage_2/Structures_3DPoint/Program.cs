using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_3DPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            _3DPoint point1 = new _3DPoint(1, 2, 3);
            _3DPoint point2 = new _3DPoint(0, 0, 0);
            _3DPoint point3 = new _3DPoint(4, 5, 6);

            point1.Print();
            point2.Print();
            point3.Print();

            Console.WriteLine(point1.DistanceFromOrigin());
            Console.WriteLine(point1.DistanceBetween2Points(point2));
            Console.WriteLine(point1.DistanceBetween2Points(point3));
            Console.WriteLine(point3.ScalarProduct(point1));

            Console.ReadKey();
        }
    }
}
