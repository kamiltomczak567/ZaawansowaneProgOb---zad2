using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cw2zad2
{
// INTERFEJS //
 interface IBohater {
        void BijWroga();
        void SprawdzHp();
    }
// INTERFEJS END//

    abstract class Bohater : IBohater {
        public int Hp;
        public int Atak;

        public enum Rasa { 
            Smok,
            Trybandyta,
            Aniol
        }

    
    public void  BijWroga()
    {
        Console.WriteLine("Obrazenia " + Atak);
 	    //throw new NotImplementedException();
    }

    public void  SprawdzHp()
    {
        Console.WriteLine("Pozostało Ci zycia "+ Hp);
 	    //throw new NotImplementedException();
    }
    }

    internal class Mag : Bohater {
        private int mana;
      
        public Mag() {
            this.mana = 200;
            this.Hp = 100;
            this.Atak = 10;
        }

        public void RzućCzar() {
            Console.WriteLine("Jestem magiem, rzucam czary pyyyk");
        }
    }

    internal class Wojownik : Bohater {
        
        public Wojownik() {
            this.Atak = 50;
            this.Hp = 200;
          
        }
        public void Rztop() {
            Console.WriteLine("Jestem wojownikiem, rzucam topór pyyyk za 50");
        }
    }

    internal class Rzezimieszek : Bohater {

        private int energia;
        public Rzezimieszek() {
            this.Atak = 15;
            this.Hp = 150;
            this.energia = 50;

        }

      
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wojownik Wojak = new Wojownik();
            Mag Magik = new Mag();
            Rzezimieszek Andrzej = new Rzezimieszek();
            Console.WriteLine("Wojak bije Andrzeja bardzo mocno ");
            Wojak.BijWroga();
            Console.WriteLine("Magic rzuca czar w Andrzeja ");
            Magik.RzućCzar();
            Console.WriteLine("Andrzej probuje oddac, ale slabo mu wychodzi ");
            Andrzej.BijWroga();
            Wojak.Rztop();
            Console.WriteLine("Wojak trail Andrzeja krytycznie toporem");

            Console.WriteLine("Andrzej ginie ");

            Console.ReadKey();

           
        }
    }
}
