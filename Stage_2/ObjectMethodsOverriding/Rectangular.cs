using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethodsOverriding
{
    class Rectangular
    {
        public double length;
        public double width;

        public Rectangular(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override bool Equals(object obj)
        {
            Rectangular rect = obj as Rectangular;
            if (this.length * this.width == rect.length * rect.width) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return (int)Math.Pow(this.length * this.width, 3);
        }

        public override string ToString()
        {
            return $"The rectangular has {width} width and {length} length.";
        }
    }
}
