using System;
using System.Collections.Generic;
using System.Linq;

namespace Education
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                ShowAllCombination(GetRandomMass());
                Console.ReadKey();
                Console.Clear();
            }

            // endless 
        }

        private static int School(int[] numbers, int n)
        {
            return numbers.Count(i => i == n) * n - n * 3;
        }

        public static int Street(int[] number)
        {
            int[] s = {1, 2, 3, 4, 5};
            var result = number.OrderBy(i => i).ToArray();

            if (s == result)
            {
                return 15;
            }

            return 0;
        }

        public static int FullHouse(int[] mass)
        {
            var sort = mass
                .GroupBy(i => i)
                .Where(c => c.Count() == 3);
            
            if (sort.Count()!= 0)
            {
                var se = sort.First().Key;
                var s2 = mass.Where(m => m != se).ToArray();

                if (s2[0].Equals(s2[1]))
                {
                    return s2[0] * 2 + se * 3;
                }
                
            }
            return 0;
        }

        public static int Pair(int[] mass)
        {
            var sort = mass
                .GroupBy(i => i)
                .Where(c => c.Count() == 2);

            if (sort.Count()==2)
            {
               return sort.Sum(i => i.Key *2);
            }

            return 0;
        }

        public static int LongStreet(int[] number)
        {
            int[] s = {2, 3, 4, 5, 6};
            var result = number.OrderBy(i => i).ToArray();

            if (s == result)
            {
                return 15;
            }

            return 0;
        }

        private static int[] GetRandomMass()
        {
            Random rnd = new Random();
            var m = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                m.Add(rnd.Next(1, 7));
                Console.Write(m[i]);
            }

            Console.WriteLine();
            return m.ToArray();
        }

        static int IdenticalСards(int[] mass, int numCombination)
        {
            var s = mass
                .GroupBy(i => i)
                .Where(n => n.Count() > numCombination - 1);

            return s.Any() ? s.Max(i => i.Key) * numCombination : 0;
        }

        static void ShowAllCombination(int[] mass)
        {
            Console.WriteLine("Combination for School");
            Console.WriteLine($"One:       {School(mass, 1)}");
            Console.WriteLine($"Two:       {School(mass, 2)}");
            Console.WriteLine($"Three:     {School(mass, 3)}");
            Console.WriteLine($"Four:      {School(mass, 4)}");
            Console.WriteLine($"Five:      {School(mass, 5)}");
            Console.WriteLine($"Six:       {School(mass, 6)}");
            Console.WriteLine("_*_*_*_*_*_*_*_*_*_*_*_*_");
            Console.WriteLine("2:          " + IdenticalСards(mass, 2));
            Console.WriteLine("2+2:        " + Pair(mass));
            Console.WriteLine("3:          " + IdenticalСards(mass, 3));
            Console.WriteLine("3+2:        " + FullHouse(mass));
            Console.WriteLine("4:          " + IdenticalСards(mass, 4));
            Console.WriteLine("Street:     " + Street(mass));
            Console.WriteLine("StreetLong: " + LongStreet(mass));
            Console.WriteLine("5:          " + IdenticalСards(mass, 5));
            Console.WriteLine("");
        }
    }
}