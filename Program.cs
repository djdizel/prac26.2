using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac26._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2.1, 3.2);
            point1.Print();
            point1.SetX(1.2);
            point1.SetY(2.3);
            Console.WriteLine("Обновленно значение X,Y");
            point1.Print();

            //    Point[] points = new Point[4]{
            //    new Point(3,2),
            //    new Point(4,-3),
            //    new Point(-2,-5),
            //    new Point(2,-5),
            //};
            //    foreach (Point point in points)
            //    {
            //        point.Printar();
            //    }

            //Point[] points = new Point[4];
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine("Введите координаты {0}-й точки", i + 1);
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    double y = Convert.ToDouble(Console.ReadLine());
            //    points[i] = new Point(x, y);
            //}

            List<Point> points = new List<Point>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"x {i + 1} точки - ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write($"y {i + 1} точки - ");
                int y = Convert.ToInt32(Console.ReadLine());
                points.Add(new Point(x, y));
                points[i].Printar();
            }

                Console.ReadKey();
        }
    }
}
