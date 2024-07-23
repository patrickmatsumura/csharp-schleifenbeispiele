using System;

namespace BVS.SchleifenBeispiele.ForeachOhneSteuerung
{
    static class Program
    {
        static void Main()
        {
            string[] staedte = { "Berlin", "München", "Hamburg", "Köln" };
            foreach (string stadt in staedte)
            {
                Console.WriteLine($"Stadt: {stadt}");
            }
        }
    }
}