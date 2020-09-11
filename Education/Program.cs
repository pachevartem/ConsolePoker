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

        static int MaxEqCombination(int[] mass, int numCombination)
        {
            var s = mass
                .GroupBy(i => i)
                .Where(n => n.Count() > numCombination - 1);

            return s.Any() ? s.Max(i => i.Key) * numCombination : 0;
        }

        static void ShowAllCombination(int[] mass)
        {
            Console.WriteLine("Combination for School");
            Console.WriteLine($"One: {School(mass, 1)}");
            Console.WriteLine($"Two: {School(mass, 2)}");
            Console.WriteLine($"Three: {School(mass, 3)}");
            Console.WriteLine($"Four: {School(mass, 4)}");
            Console.WriteLine($"Five: {School(mass, 5)}");
            Console.WriteLine($"Six: {School(mass, 6)}");
            Console.WriteLine("_*_*_*_*_*_*_*_*_*_*_*_*_");
            Console.WriteLine("2: " + MaxEqCombination(mass, 2));
            Console.WriteLine("3: " + MaxEqCombination(mass, 3));
            Console.WriteLine("4: " + MaxEqCombination(mass, 4));
            Console.WriteLine("5: " + MaxEqCombination(mass, 5));
            Console.WriteLine("");
        }
    }
}