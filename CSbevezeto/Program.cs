namespace CSbevezeto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Feladat1();
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