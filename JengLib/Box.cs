using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new Exception("Error.");
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new Exception("Error.");
                }
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new Exception("Error.");
                }
            }
        }
        public string display_dimensions()
        {
            return "Length = " + this.Length + ". Width = " + this.Width + ". Height = " + this.Height + ".";
        }
        public double display_volume()
        {
            return Length * Width * Height;
        }
    }
}
