using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cwiczenia2
{

    // ZADANIE 1 //
    interface Samochod { 
       void WypiszMarke();
       void WypiszSalon();
    }

    class AstonMartin : Samochod {

        public void WypiszMarke()
        {
            Console.WriteLine("Marka: Aston Martin");
        }

        public void WypiszSalon()
        {
            Console.WriteLine("Salon: Aston Martin Olsztyn");
        }
    }
    class RangeRover : Samochod {

        public void WypiszMarke()
        {
            Console.WriteLine("Marka: Range Rover");
        }

        public void WypiszSalon()
        {
            Console.WriteLine("Salon: Range Rover Warszawa");
        }
    }

    class RollsRoyce : Samochod {

        public void WypiszMarke()
        {
            Console.WriteLine("Marka: Rolls Royce");
        }

        public void WypiszSalon()
        {
            Console.WriteLine("Salon: Rolls Royce Gliwice");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AstonMartin aston = new AstonMartin();
            aston.WypiszMarke();
            aston.WypiszSalon();

            Console.ReadLine();
        }
    }
}
