using System;
using SquareLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 7, b = 6, c = 3, r = 4;
            double p = (a + b + c) / 2;
            double St = Class1.Triagle(a,b,c);
            double Sr = Class1.Circle(r);
            if (Class1.is90grace(a, b, c)) Console.WriteLine("Nреугольник прямоугольный");
            Console.WriteLine(St);
            Console.WriteLine(Sr);
            Console.Read();
        }
    }
}
