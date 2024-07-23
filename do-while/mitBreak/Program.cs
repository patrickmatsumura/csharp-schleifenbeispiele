using System;

namespace BVS.SchleifenBeispiele.DoWhileMitBreak
{
    static class Program
    {
        static void Main()
        {
            string? name;
            Console.WriteLine("Geben Sie Namen ein (geben Sie 'exit' ein, um zu beenden):");
            do
            {
                name = Console.ReadLine();
                if (name == null) continue;
                if (name == "exit")
                {
                    Console.WriteLine("Programm beendet.");
                    break;
                }
                Console.WriteLine($"Eingegebener Name: {name}");
            } while (true);
        }
    }
}