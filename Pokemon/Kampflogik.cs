using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    class Kampflogik
    {

        public void Angriff(Pokemon angreifer, Pokemon verteidiger, Delegate Attacke) {

        }

        public bool Volltreffer()
        {
            Random r = new Random();
            int i = r.Next(1, 6);
            if (i == 3)
            {
                return true;
            }
            return false;
        }
    }
}
