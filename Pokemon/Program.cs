using System;
using System.Threading;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pikachu = new Pokemon
            {
                Geschlecht = false,
                Gesundheit = 1000,
                Gewicht = 6,
                Typ = "Elektro",
                Level = 5,
                Geschwindigkeit = 85,
                Name = "Pikachu",
                Nummer = 25
            };

            Pokemon schiggy = new Pokemon
            {
                Geschlecht = false,
                Gesundheit = 1000,
                Typ = "Wasser",
                Gewicht = 9,
                Level = 6,
                Geschwindigkeit = 40,
                Name = "Schiggy",
                Nummer = 7
            };

            Pokemon glumanda = new Pokemon
            {
                Geschlecht = true,
                Gesundheit = 1000,
                Typ = "Feuer",
                Gewicht = 4,
                Level = 7,
                Geschwindigkeit = 30,
                Name = "Glumanda",
                Nummer = 4
            };

            Pokemon flamiau = new Pokemon
            {
                Geschlecht = true,
                Gesundheit = 1000,
                Typ = "Feuer",
                Gewicht = 9,
                Level = 6,
                Geschwindigkeit = 40,
                Name = "Flamiau",
                Nummer = 725
            };

            Kampf(glumanda, flamiau);
        }

        private static void Kampf(Pokemon pkmn1, Pokemon pkmn2)
        {
            Console.WriteLine("Der Kampf beginnt ...");

            while (pkmn1.Gesundheit != 0 && pkmn2.Gesundheit != 0)
            {
                Thread.Sleep(2000);

                Console.WriteLine("Gesundheit von {0}: {1}", pkmn1.Name, pkmn1.Gesundheit);
                Console.WriteLine("Gesundheit von {0}: {1}", pkmn2.Name, pkmn2.Gesundheit);
                Console.WriteLine("{0} greift mit Tackle an! Schaden: {1}", pkmn1.Name, pkmn1.Tackle());

                if (pkmn1.Volltreffer())
                {
                    Console.WriteLine("Ein Volltreffer!");
                    pkmn2.EnergieAbziehen(pkmn1.Tackle() * 2);
                }
                else
                {
                    pkmn2.EnergieAbziehen(pkmn1.Tackle());
                }

                Console.WriteLine("{0} greift mit Tackle an! Schaden: {1}", pkmn2.Name, pkmn2.Tackle());

                if (pkmn1.Volltreffer())
                {
                    Console.WriteLine("Ein Volltreffer!");
                    pkmn1.EnergieAbziehen(pkmn2.Tackle() * 2);
                }
                else
                {
                    pkmn1.EnergieAbziehen(pkmn2.Tackle());
                }

                if (pkmn1.Gesundheit == 0 || pkmn2.Gesundheit == 0)
                {
                    Console.WriteLine("Kampf vorbei.");
                    if (pkmn1.Gesundheit == 0)
                    {
                        Console.WriteLine("{0} ist tot.", pkmn1.Name);
                    }
                    else
                    {
                        Console.WriteLine("{0} ist tot.", pkmn2.Name);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
