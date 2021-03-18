using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class Circle
    {
        private double radius = -1;
        public string text;
        public double Radius
        {
            get
            {
                if (radius == -1)
                {
                    throw new Exception("Error.");
                }
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new Exception("Error.");
                }
            }
        }
        public double diameter()
        {
            return this.radius * 2;
        }
        public double area()
        {
            return Math.Pow(this.radius, 2) * 3.14;
        }
        public double perimeter()
        {
            return 2 * 3.14 * radius;
        }
    }
}
