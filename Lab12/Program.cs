using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Координата точки X=");
                int x1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Координата точки Y=");
                int y1 = Convert.ToInt32(Console.ReadLine());

                Circle.CheckPoint(x1, y1);

            }
            catch (Exception)
            {
                Console.WriteLine("Введено некорректное значение");
            }
            Console.ReadKey();
        }
    }
    public static class Circle
    {
        public const int R = 5;
        public const int x0 = 9;
        public const int y0 = 3;


        public static void LenghtCircle(int R, out double lenghtCircle)
        {
            lenghtCircle = 2 * R * Math.PI;

        }
        public static void AreaCircle(int R, out double areaCircle)
        {
            areaCircle = Math.Pow(R, 2) * Math.PI;

        }
        public static void CheckPoint(int x, int y)
        {

            if (Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2) == Math.Pow(R, 2))
            {
                Console.WriteLine("Точка с заданными координатами лежит на окружности");
            }
            else
            {
                Console.WriteLine("Точка с заданными координатами не лежит на окружности");
            }
        }
    }

}
