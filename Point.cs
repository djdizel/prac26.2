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
        private double x, y;
        public static double count;

        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
            count++;
        }
        /// <summary>
        /// метод Length, возвращающий расстояние от точки до начала координат;
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Length(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
        //public Point()
        //{
        //    this.X = 1.0;
        //    this.Y = 1.0;
        //    count++;
        //}
        //static Point()
        //{
        //    count = 0;
        //}

        //public double GetX()
        //{
        //    return x;
        //}
        //public double GetY()
        //{
        //    return y;
        //}
        //public void SetX(double x)
        //{
        //    this.x = x;
        //}
        //public void SetY(double y)
        //{
        //    this.y = y;
        //}
        //public void Print()
        //{
        //    Console.WriteLine($"x={GetX()},y={GetY()}");
        //}
        /// <summary>
        /// метод для вывода координат точки.
        /// </summary>
        public void Printar()
        {
            Console.WriteLine($"x={X},y={Y}");
        }

        public void Checking(double x, double y)
        {
            if(x>=0&&y>=0)
            {
                Console.WriteLine("в первой четверти");
            }
            if (x <= 0 && y >= 0)
            {
                Console.WriteLine("во второй четверти");
            }
            if (x <= 0 && y <= 0)
            {
                Console.WriteLine("в третьей четверти");
            }
            if (x >= 0 && y <= 0)
            {
                Console.WriteLine("в четвертой четверти");
            }
        }
    }
}
