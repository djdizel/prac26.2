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
            Point point1 = new Point(2.1,3.2);
            point1.Print();
            point1.SetX(1.2);
            point1.SetY(2.3);
            Console.WriteLine("Обновленно значение X,Y");
            point1.Print();

        }
    }
}
