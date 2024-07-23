using System;

namespace BVS.SchleifenBeispiele.DoWhileMitReturn
{
    static class Program
    {
        static void Main()
        {
            string? passwort;
            Console.WriteLine("Geben Sie das Passwort ein (richtiges Passwort ist 'pass123'):");
            do
            {
                passwort = Console.ReadLine();
                if (passwort == null) continue;
                if (passwort == "pass123")
                {
                    Console.WriteLine("Zugang gewährt.");
                    return;
                }
                else
                {
                    Console.WriteLine("Falsches Passwort, bitte erneut versuchen.");
                }
            } while (true);
        }
    }
}