using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    class Pokemon
    {
        public string Typ { get; set; }

        //false = männlich, true = weiblich
        public bool Geschlecht { get; set; }

        public string Name { get; set; }

        public int Nummer { get; set; }

        public int Gewicht { get; set; }

        public int Geschwindigkeit { get; set; }

        public int Level { get; set; }

        private int gesundheit;

        public int Gesundheit
        {
            get { return gesundheit; }
            set
            {
                if (value < 0)
                {
                    gesundheit = 0;
                }
                else if (value > 1000)
                {
                    gesundheit = 0;
                }
                else
                {
                    gesundheit = value;
                }
            }
        }




        //Methoden
        public int Tackle()
        {
            return (Gewicht + Geschwindigkeit) * Level;
        }

        public void EnergieAbziehen(int Schaden)
        {
            Gesundheit = Gesundheit - Schaden;
        }

    }
}
