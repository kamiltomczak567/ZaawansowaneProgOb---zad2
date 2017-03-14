using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cwiczenie2zad3
{
    class Program
    {
        /////////////// COS NIE GRA W TYM ZADANIU //////////
        class Osoba {
            protected string imie;
            protected string nazwisko;
            protected string dataUrodzenia;
            public Osoba(string imie, string nazwisko, string dataUrodzenia) { 
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.dataUrodzenia = dataUrodzenia;
            }

            public void wypiszInfo() {
                Console.WriteLine("Info to : :D");
            }
        }

        class Student : Osoba {
            private int rok;
            private int grupa;
            private int nrIndeksu;
            public Student(int rok, int grupa, int nrIndeksu, string imie,string nazwisko, string dataUrodzenia) : base(imie, nazwisko, dataUrodzenia) {
                this.rok = rok;
                this.grupa = grupa;
                this.nrIndeksu = nrIndeksu;
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.dataUrodzenia = dataUrodzenia;
            }
            public void wypiszInfo() {
                
            }
            public void dodajOCene(string nazwaPrzedmiotu, string data, double wartosc) { }
            public void wypiszOceny() { }
            public void wypiszOceny(string nazwaPrzedmiotu) { }
            public void usuńOcene(string nazwaPrzedmiotu, string data, double wartosc) { }
            public void usunOceny() { }
            public void usunOceny(string nazwaPrzedmiotu) { }
        }

        public class Pilkarz : Osoba {
            private string pozycja;
            private string klub;
            private int liczbaGoli=0;
            public Pilkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub) : base (imie,nazwisko,dataUrodzenia) {
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.dataUrodzenia = dataUrodzenia;
                this.pozycja = pozycja;
                this.klub = klub;
            }

            public void wypiszInfo() { }
            public void strzelGOla() { }
        }

        public class Ocena {

            private string nazwaPrzedmiotu;
            private string data;
            private double wartosc;

            public Ocena(string nazwaPrzedmiotu, string data, double wartosc) {
                this.nazwaPrzedmiotu = nazwaPrzedmiotu;
                this.data = data;
                this.wartosc = wartosc;
            }

            public void wypiszInfo();
        
        }

        public class PilkarzReczny : Pilkarz {

            public PilkarzReczny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub): base (imie,nazwisko,dataUrodzenia,pozycja,klub)
            {
              
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.dataUrodzenia = dataUrodzenia;

            }

            public void strzelGola() { }
        }

        public class PilkarzNozny : Pilkarz {

            public PilkarzNozny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
                : base(imie, nazwisko, dataUrodzenia, pozycja, klub)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.dataUrodzenia = dataUrodzenia; 
            }
            public void strzelGola() { }
        }


        static void Main(string[] args)
        {
            List<Osoba> osoba = new List<Osoba>();
            Osoba osoba1 = new Osoba("Andrzej","Wiatrak", "1 czerwca 2003");
            Osoba osoba2 = new Osoba("Kamil", "Pączek", "2 czerwca 2004");
            Osoba osoba3 = new Osoba("Piotrek", "Oponek", "3 czerwca 2005");
            osoba.Add(osoba1);
            osoba.Add(osoba2);
            osoba.Add(osoba3);

            foreach (Osoba osa in osoba)
            {
                Console.WriteLine(osa);
            }
           
        }
    }
}
