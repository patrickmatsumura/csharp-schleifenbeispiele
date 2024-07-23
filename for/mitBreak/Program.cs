using System;

namespace BVS.SchleifenBeispiele.ForMitBreak
{
    static class Program
    {
        static void Main()
        {
            int[] zahlen = { 1, 2, 3, 4, 5 };
            int gesuchteZahl = 3;
            for (int i = 0; i < zahlen.Length; i++)
            {
                if (zahlen[i] == gesuchteZahl)
                {
                    Console.WriteLine($"Zahl {gesuchteZahl} gefunden an Position {i}.");
                    break;
                }
            }
        }
    }
}