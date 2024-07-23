using System;

namespace BVS.SchleifenBeispiele.ForOhneSteuerung
{
    static class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"3 x {i} = {3 * i}");
            }
        }
    }
}