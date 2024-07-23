using System;

namespace BVS.SchleifenBeispiele.ForMitContinue
{
    static class Program
    {
        static void Main()
        {
            int[] zahlen = { 1, -2, 3, -4, 5 };
            for (int i = 0; i < zahlen.Length; i++)
            {
                if (zahlen[i] < 0)
                {
                    continue;
                }
                Console.WriteLine($"Quadratwurzel von {zahlen[i]} ist {Math.Sqrt(zahlen[i])}");
            }
        }
    }
}