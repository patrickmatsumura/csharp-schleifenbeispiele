using System;

namespace BVS.SchleifenBeispiele.WhileMitContinue
{
    static class Program
    {
        static void Main()
        {
            int zahl;
            int geradeZahlenSumme = 0;
            Console.WriteLine("Geben Sie Zahlen ein (geben Sie -1 ein, um zu beenden):");
            string? eingabe;
            while ((eingabe = Console.ReadLine()) != "-1")
            {
                if (eingabe == null) continue;
                zahl = int.Parse(eingabe);
                if (zahl % 2 != 0)
                {
                    continue;
                }
                geradeZahlenSumme += zahl;
            }
            Console.WriteLine($"Summe der geraden Zahlen: {geradeZahlenSumme}");
        }
    }
}