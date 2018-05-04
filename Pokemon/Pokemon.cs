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

        public int Gesundheit { get; set; }



        //Methoden
        public int Tackle()
        {
            return (Gewicht + Geschwindigkeit) * Level;
        }


    }
}
