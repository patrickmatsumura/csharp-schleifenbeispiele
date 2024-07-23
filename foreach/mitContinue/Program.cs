using System;

namespace BVS.SchleifenBeispiele.ForeachMitContinue
{
    static class Program
    {
        static void Main()
        {
            string[] staedte = { "Berlin", "München", "Hamburg", "Köln" };
            string ausgelasseneStadt = "München";
            foreach (string stadt in staedte)
            {
                if (stadt == ausgelasseneStadt)
                {
                    continue;
                }
                Console.WriteLine($"Stadt: {stadt}");
            }
        }
    }
}