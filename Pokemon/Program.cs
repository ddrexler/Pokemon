using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pikachu = new Pokemon
            {
                Geschlecht = false,
                Gewicht = 6,
                Level = 5,
                Geschwindigkeit = 85,
                Name = "Pikachu",
                Nummer = 25
            };

            Pokemon schiggy = new Pokemon
            {
                Geschlecht = false,
                Gewicht = 9,
                Level = 6,
                Geschwindigkeit = 40,
                Name = "Schiggy",
                Nummer = 7
            };

            Console.WriteLine("{0} greift mit Tackle an! Schaden: {1}", pikachu.Name, pikachu.Tackle());
            Console.WriteLine("{0} greift mit Tackle an! Schaden: {1}", schiggy.Name, schiggy.Tackle());

            Console.ReadLine();
        }
    }
}
