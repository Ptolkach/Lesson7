using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static double STriangle(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите стороны второго треугольника");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());

            if (STriangle(a1, b1, c1) > STriangle(a2, b2, c2))
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else if (STriangle(a1, b1, c1) < STriangle(a2, b2, c2))
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }
            Console.ReadKey();

        }
    }
}
