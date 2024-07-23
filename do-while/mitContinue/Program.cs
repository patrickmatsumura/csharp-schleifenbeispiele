using System;

namespace BVS.SchleifenBeispiele.DoWhileMitContinue
{
    static class Program
    {
        static void Main()
        {
            int zahl;
            int positiveZahlenAnzahl = 0;
            Console.WriteLine("Geben Sie Zahlen ein (geben Sie 0 ein, um zu beenden):");
            string? eingabe;

            do
            {
                eingabe = Console.ReadLine();

                // Überprüfung auf ungültige Eingabe
                while (!int.TryParse(eingabe, out zahl))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                    eingabe = Console.ReadLine();
                }

                if (zahl == 0)
                {
                    break;
                }

                if (zahl < 0)
                {
                    Console.WriteLine("Eingabe muss positiv sein. Bitte versuchen Sie es erneut.");
                    continue;
                }

                positiveZahlenAnzahl++;
            } while (true);

            Console.WriteLine($"Anzahl der positiven Zahlen: {positiveZahlenAnzahl}");
        }
    }
}