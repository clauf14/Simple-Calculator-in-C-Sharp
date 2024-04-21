using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIDemo
{
    class OperatiiCalculator
    {
        public static double Adunare(double x1, double x2)
        {
            return x1 + x2;
        }

        public static double Scadere(double x1, double x2)
        {
            return x1 - x2;
        }

        public static double Impartire(double x1, double x2)
        {
            if (x2 == 0)
            {
                Console.WriteLine("Eroare: Impartirea la zero nu e posibila.");
                return double.NaN;
            }
            else
                return x1 / x2;
        }

        public static double Inmultire(double x1, double x2)
        {
            return x1 * x2;
        }

        public static double ChangeNumberSign(double x)
        {
            return x * (-1);
        }

        public static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public static double ToPower2(double x)
        {
            return Math.Pow(x, 2);
        }

        public static double UnuImpartitLa(double x)
        {
            return 1 / x;
        }

    }
}
