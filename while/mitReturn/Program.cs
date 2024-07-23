using System;

namespace BVS.SchleifenBeispiele.WhileMitReturn
{
    static class Program
    {
        static void Main()
        {
            int alter;
            Console.WriteLine("Geben Sie Ihr Alter ein (zwischen 0 und 120):");
            while (true)
            {
                string? eingabe = Console.ReadLine();
                if (eingabe == null) continue;
                alter = int.Parse(eingabe);
                if (alter >= 0 && alter <= 120)
                {
                    Console.WriteLine($"Ihr Alter ist: {alter}");
                    return;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe, bitte erneut versuchen.");
                }
            }
        }
    }
}