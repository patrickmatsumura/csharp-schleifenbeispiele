using System;

namespace BVS.SchleifenBeispiele.WhileMitBreak
{
    static class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int geheimzahl = rand.Next(1, 11);
            int versuch;
            Console.WriteLine("Errate die Zahl zwischen 1 und 10 (oder geben Sie 0 ein, um zu beenden):");
            while (true)
            {
                string? eingabe = Console.ReadLine();
                if (eingabe == null) continue;
                versuch = int.Parse(eingabe);
                if (versuch == 0)
                {
                    Console.WriteLine("Spiel beendet.");
                    break;
                }
                if (versuch == geheimzahl)
                {
                    Console.WriteLine("Glückwunsch! Sie haben die richtige Zahl erraten.");
                    break;
                }
                else
                {
                    Console.WriteLine("Falsch geraten, versuchen Sie es erneut.");
                }
            }
        }
    }
}