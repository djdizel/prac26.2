using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prac26._2
{
    internal class Point
    {
        private double x,y;
        public static double count;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Point(double x, double y) 
        {
            this.X = x;
            this.Y = y;
            count++;
        }
        public Point()
        {
            this.X = 1.0;
            this.Y = 1.0;
            count++;
        }
        static Point()
        {
            count = 0;
        }

        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public void SetX(double x)
        {
            this.x=x;
        }
        public void SetY(double y)
        {
            this.y=y;
        }
        public void Print()
        {
            Console.WriteLine($"x={GetX()},y={GetY()}");
        }
        public void Printar()
        {
            Console.WriteLine($"x={X},y={Y}");
        }
    }
}
