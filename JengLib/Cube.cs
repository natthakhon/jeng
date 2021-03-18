using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class Cube
    {
        private double edge;
        public Cube(double edge)
        {
            Edge = edge;
        }
        public double Edge
        {
            get
            {
                return edge;
            }
            set
            {
                if (value > 0)
                {
                    edge = value;
                }
                else
                {
                    throw new Exception("Error.");
                }
            }
        }
        public double volume()
        {
            return Math.Pow(this.edge, 3);
        }
        public double surface()
        {
            return Math.Pow(this.edge, 2);
        }
        public double total_surface()
        {
            return Math.Pow(this.edge, 2) * 6;
        }
    }
}
