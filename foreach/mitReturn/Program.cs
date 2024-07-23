using System;

namespace BVS.SchleifenBeispiele.ForeachMitReturn
{
    static class Program
    {
        static void Main()
        {
            string[] staedte = { "Berlin", "München", "Hamburg", "Köln" };
            string gesuchteStadt = "Hamburg";
            foreach (string stadt in staedte)
            {
                if (stadt == gesuchteStadt)
                {
                    Console.WriteLine($"Stadt {gesuchteStadt} gefunden.");
                    return;
                }
            }
            Console.WriteLine("Stadt nicht gefunden.");
        }
    }
}