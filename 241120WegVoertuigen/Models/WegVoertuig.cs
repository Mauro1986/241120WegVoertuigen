using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Als je klaar bent met het aanmaken van de klassen maak je een hoofdprogramma aan. Hierin maak je op
//drie verschillende manieren een vrachtwagen en een bus aan. Print de gegevens van deze aangemaakte
//voertuigen op een ordelijke manier af. 

namespace _241120WegVoertuigen.Models
{
    public class WegVoertuig
    {
        public string Naam { get; set; }
        public int Pk { get; set; }
        public int Banden { get; set; }

        
        WegVoertuig()
        { }

        public WegVoertuig(string naam, int pk, int banden)
        {
            Naam = naam;
            Pk = pk;
            Banden = banden;
        }

        public void Show()
        {
            Console.WriteLine(Naam);       
        }
        
    }
}
