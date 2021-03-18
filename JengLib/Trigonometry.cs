using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class Trigonometry
    {
        public int square_area(int s)
        {
            return s * s;
        }
        public int rectangle_area(int l, int w)
        {
            return l * w;
        }
        public double triangle_area(int b, int h)
        {
            return (b * h)/2;
        }
    }
}
