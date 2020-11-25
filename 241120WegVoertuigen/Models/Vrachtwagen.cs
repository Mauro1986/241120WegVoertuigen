using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241120WegVoertuigen.Models
{
    public class Vrachtwagen : WegVoertuig
    {
        private int laadgewicht;

        public int LaadGewicht
        {
            get
            {
                return laadgewicht;
            }
            set
            {
                laadgewicht = value;
            }
        }

        public Vrachtwagen()
        { 
        
        }

        public Vrachtwagen(string name, int pk, int banden) : base(name, pk, banden)
        {

        }

        public Vrachtwagen(string name, int pk, int banden, int laadgewicht) : base(name, pk, banden)
        {
            LaadGewicht = laadgewicht;
        }

        public new void Show()
        {
            if (laadgewicht == 0)
            {
                Console.WriteLine($"Naam:{Naam}  Pk:{Pk}  Banden:{Banden}");

            }
            else if (laadgewicht > 0)
            {
            Console.WriteLine($"Naam:{Naam}  Pk:{Pk}  Banden:{Banden} Laadgewicht:{laadgewicht}");

            }
        }
    }
}
