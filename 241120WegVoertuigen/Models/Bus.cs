using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241120WegVoertuigen.Models
{
    public class Bus : WegVoertuig
    {
        private int aantalzitplaatsen;

        public int AantalZitPlaatsen
        {
            get
            {
                return aantalzitplaatsen;
            }
            set
            {
                aantalzitplaatsen = value;
            }
        }

        public Bus()
        {

        }

        public Bus(string name, int pk, int banden) : base(name, pk, banden)
        {

        }

        public Bus(string name, int pk, int banden, int aantalzitplaatsen) : base(name, pk, banden)
        {
            AantalZitPlaatsen = aantalzitplaatsen;
        }



        public new void Show()
        {
            if (aantalzitplaatsen == 0)
            {
                Console.WriteLine($"Naam:{Naam}  Pk:{Pk}  Banden:{Banden}");

            }
            else if (aantalzitplaatsen > 0)
            {
            Console.WriteLine($"Naam:{Naam}  Pk:{Pk}  Banden:{Banden} Aantal zitplaatsen:{aantalzitplaatsen}");

            }
        }
    }

}
