using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloading
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Point operator +(Point leftPoint, Point rhs)
        {
            return new Point
            {
                X = leftPoint.X + rhs.X,
                Y = leftPoint.Y + rhs.Y
            };
        }
        public static Point operator -(Point lp, Point rp) => new Point
        {
            X = lp.X - rp.X,
            Y = lp.Y - rp.Y,
        };
        public static bool operator >=(Point lp, Point rp) => lp.X >= rp.X && lp.Y >= rp.Y;
        public static bool operator <=(Point lp, Point rp) => lp.X <= rp.X && lp.Y <= rp.Y;
 

    } 
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point { X = 5, Y = 4 };
            var point2 = new Point { X = 6, Y = 3 };
            var point3 = point1 - point2;
            if (point1 >= point2)
            {
                Console.WriteLine("Point1 is greater");
            }
            else
            {
                Console.WriteLine("Point2 is greater");
            }
        }
    }
}
