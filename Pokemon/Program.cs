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
                Level = 5,
                Geschwindigkeit = 85,
                Name = "Pikachu",
                Nummer = 25
            };

            Pokemon schiggy = new Pokemon
            {
                Geschlecht = false,
                Gesundheit = 1000,
                Gewicht = 9,
                Level = 6,
                Geschwindigkeit = 40,
                Name = "Schiggy",
                Nummer = 7
            };

            Console.WriteLine("Der Kampf beginnt ...");


            while (pikachu.Gesundheit != 0 && schiggy.Gesundheit != 0)
            {
                Thread.Sleep(2000);

                Console.WriteLine("Gesundheit von {0}: {1}", pikachu.Name, pikachu.Gesundheit);
                Console.WriteLine("Gesundheit von {0}: {1}", schiggy.Name, schiggy.Gesundheit);
                Console.WriteLine("{0} greift mit Tackle an! Schaden: {1}", pikachu.Name, pikachu.Tackle());

                if (pikachu.Volltreffer())
                {
                    Console.WriteLine("Ein Volltreffer!");
                    schiggy.EnergieAbziehen(pikachu.Tackle() * 2);
                }
                else
                {
                    schiggy.EnergieAbziehen(pikachu.Tackle());
                }

                Console.WriteLine("{0} greift mit Tackle an! Schaden: {1}", schiggy.Name, schiggy.Tackle());

                if (pikachu.Volltreffer())
                {
                    Console.WriteLine("Ein Volltreffer!");
                    pikachu.EnergieAbziehen(schiggy.Tackle() * 2);
                }
                else
                {
                    pikachu.EnergieAbziehen(schiggy.Tackle());
                }

                if (pikachu.Gesundheit == 0 || schiggy.Gesundheit == 0)
                {
                    Console.WriteLine("Kampf vorbei.");
                    if (pikachu.Gesundheit == 0)
                    {
                        Console.WriteLine("Pikachu ist tot.");
                    }
                    else
                    {
                        Console.WriteLine("Schiggy ist tot.");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
