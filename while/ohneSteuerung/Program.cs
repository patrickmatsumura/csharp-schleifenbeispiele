using System;

namespace BVS.SchleifenBeispiele.WhileOhneSteuerung
{
    static class Program
    {
        static void Main()
        {
            string? name;
            Console.WriteLine("Geben Sie Namen ein (geben Sie 'stop' ein, um zu beenden):");
            while ((name = Console.ReadLine()) != "stop")
            {
                Console.WriteLine($"Sie haben eingegeben: {name}");
            }
        }
    }
}