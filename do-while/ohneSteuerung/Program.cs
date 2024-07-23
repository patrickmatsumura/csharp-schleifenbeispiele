using System;

namespace BVS.SchleifenBeispiele.DoWhileOhneSteuerung
{
    static class Program
    {
        static void Main()
        {
            int zahl = 0;
            int summe = 0;
            Console.WriteLine("Geben Sie positive Zahlen ein (eine negative Zahl beendet das Programm):");
            string? eingabe;
            do
            {
                eingabe = Console.ReadLine();
                if (eingabe == null) continue;
                zahl = int.Parse(eingabe);
                if (zahl >= 0)
                {
                    summe += zahl;
                }
            } while (zahl >= 0);
            Console.WriteLine($"Summe der eingegebenen positiven Zahlen: {summe}");
        }
    }
}