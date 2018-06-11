using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_KAPAKABANA
{
    class Sedzia
    {
        private string imie;
        private string nazwisko;
        private int id;

        //Publiczny konstruktor 3-parametrowy przyjmujący 2 parametry typu string oraz 1 typu int.
        //Ustawia prywatne pola klasy.
        public Sedzia(string name, string surname, int idd)
        {
            this.imie = name;
            this.nazwisko = surname;
            this.id = idd;
        }

        //Publiczna metoda zwracająca imię sędziego.
        public string getImie()
        {
            return this.imie;
        }

        //Publiczna metoda zwracająca nazwisko sędziego.
        public string getNazwisko()
        {
            return this.nazwisko;
        }

        //Publiczna metoda zwracająca id sędziego.
        public int getId()
        {
            return this.id;
        }
    }
}
