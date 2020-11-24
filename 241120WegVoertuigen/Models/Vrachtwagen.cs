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


        public Vrachtwagen(string name, int pk, int banden) : base()
        {
            LaadGewicht = laadgewicht;
        }
 

    }
}
