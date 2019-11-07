using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib
{
    public class Class1
    {
        public static double Triagle(double x, double y, double z)  //площадь треугольника
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }

        public static double Circle(double r) //площадь круга
        {
            return Math.PI * r * r;
        }

        public static bool is90grace(double x, double y, double z) //проверка на прямоугольность
        {
            if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x) return true; //теорема Пифагора
            else return false;
        }
    }
}
