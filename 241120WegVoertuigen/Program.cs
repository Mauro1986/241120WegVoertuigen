using _241120WegVoertuigen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241120WegVoertuigen
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = new string('-', 50);

            Vrachtwagen vrachtwagen1 = new Vrachtwagen();
            vrachtwagen1.Show();

            Console.WriteLine(line);

            Vrachtwagen vrachtwagen2 = new Vrachtwagen("Jeff", 400, 6);
            vrachtwagen2.Show();

            Console.WriteLine(line);

            Vrachtwagen vrachtwagen3 = new Vrachtwagen("OpleggerTruck", 500, 8, 1000);
            vrachtwagen3.Show();

            Console.WriteLine(line);
            Console.WriteLine(line);

            Bus bus1 = new Bus();
            bus1.Show();

            Console.WriteLine(line);

            Bus bus2 = new Bus("Ottobus", 250, 4);
            bus2.Show();

            Console.WriteLine(line);

            Bus bus3 = new Bus("Snelbus", 500, 8, 40);
            bus3.Show();

        }
    }
}
