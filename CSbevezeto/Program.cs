using System;

namespace CSbevezeto
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Feladat1();
            //Feladat4();
            Feladat13();
        }

        private static void Feladat13()
        {
            /*
             * Készítsen játékprogramot, amely gondol egy számot 1 és 100 között.
             * A felhasználó addig találgathat, amíg nem találja el a keresett 
             * számot. A számítógép minden rossz tipp után írja ki, hogy a 
             * gondolt szám nagyobb vagy kisebb.
             */
            Console.WriteLine("Gondoltam egy számra 1 és 100 között");
            Random rnd = new Random();
            //int gondolt = rnd.Next(100) + 1;
            int gondolt = rnd.Next(1, 101);
            int felhasznaloTippje = 0;
            while (felhasznaloTippje != gondolt)
            {
                Console.Write("Tippelj: ");
                felhasznaloTippje = int.Parse(Console.ReadLine());
                if (felhasznaloTippje < gondolt)
                {
                    Console.WriteLine("A gondolt szám nagyobb");
                } 
                else if (felhasznaloTippje > gondolt)
                {
                    Console.WriteLine("A gondolt szám kisebb");
                } 
                else
                {
                    Console.WriteLine("Erre a számra gondoltam");
                }
            }
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