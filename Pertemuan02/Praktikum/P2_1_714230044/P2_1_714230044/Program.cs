using System;

namespace P2_1_714230044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan angka pertama : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan angka kedua : ");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"{x} + {y} = {x+y}");
            Console.WriteLine($"{x} - {y} = {x-y}");
            Console.WriteLine($"{x} x {y} = {x*y}");
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
    }
}