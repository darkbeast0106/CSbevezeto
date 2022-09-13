using System;

namespace CSbevezeto
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Feladat1();
            Feladat4();
        }

        private static void Feladat4()
        {
            Console.Write("Adja meg a háromszög 'a' oldalát(cm): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Adja meg a háromszög 'b' oldalát(cm): ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Adja meg a háromszög 'c' oldalát(cm): ");
            double c = double.Parse(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                double kerulet = a + b + c;
                Console.WriteLine("A háromszög kerülete {0} cm", kerulet);
            }
            else
            {
                Console.WriteLine("Hibás adatok");
            }
        }

        private static void Feladat1()
        {
            Console.Write("Adja meg a medence átmérőjét (m): ");
            double atmero = double.Parse(Console.ReadLine());
            Console.Write("Adja meg a medence mélység (m): ");
            double melyseg = double.Parse(Console.ReadLine());
            double sugar = atmero / 2;
            double alapTerulet = sugar * sugar * Math.PI;
            double terfogat = alapTerulet * melyseg;
            Console.WriteLine($"A medencébe {terfogat:0.000} köbméter víz fér.");
        }
    }
}