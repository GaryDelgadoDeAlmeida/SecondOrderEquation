using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondOrderEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            double x1 = 0, x2 = 0, delta;
            string msg = "";

            Console.WriteLine("Veuillez insérer le nombre a");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Veuillez insérer le nombre b");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Veuillez insérer le nombre c");
            c = Convert.ToSingle(Console.ReadLine());

            delta = Math.Pow(-b, 2) - (4 * a * c);

            if(delta < 0)
            {
                msg = "L'équation " + a + "x² + " + b + "x + " + c + " = 0 n'a pas de solution réelle.";
            }
            else if(delta == 0)
            {
                msg = "L'équation " + a +"x² + " + b +"x + " + c + " = 0 a une solution unique.";
                x1 = -(b / 2 * a);
            }
            else
            {
                msg = "L'équation " + a + "x² + " + b + "x + " + c + " = 0 a deux solutions distinctes";
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            }

            Console.WriteLine("\n" + msg + "\n\nx1 = " + x1 + "\nx2 = " + x2);
            Console.ReadLine();
        }
    }
}
