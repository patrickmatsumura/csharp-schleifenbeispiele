using System;

namespace BVS.SchleifenBeispiele.ForeachMitBreak
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
                    break;
                }
            }
        }
    }
}