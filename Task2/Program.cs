using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static double VKub(int l) => l * l * l;
        static double SKub(int l) => l * l * 6;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int l=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Объем куба: {VKub(l)} Площадь поверхности: {SKub(l)}");
            Console.ReadKey();
        }
    }
}
