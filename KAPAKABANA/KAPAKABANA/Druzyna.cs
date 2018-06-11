using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_KAPAKABANA
{
    public class Druzyna
    {
        private string nazwa;
        private int id;
        private int liczbaZwyciestw = 0;

        //Publiczny konstruktor 2-parametrowy klasy Drużyna 
        //przyjmujący jako paramtery string oraz int oraz ustawia prywatne pola klasy.
        public Druzyna(string nazw, int idd)
        {
            this.nazwa = nazw;
            this.id = idd;
        }

        //Publiczna metoda zwiększająca liczbę zwycięstw drużyny.
        public void setLiczbaZwyciestw()
        {
            this.liczbaZwyciestw++;
        }

        //Publiczna metoda zwracająca liczbę zwycięstw drużyny.
        public int getLiczbaZwyciestw()
        {
            return this.liczbaZwyciestw;
        }

        //Pbuliczna metoda zwracająca nazwę drużyny.
        public string getNazwa()
        {
            return this.nazwa;
        }

        //Publiczna metoda zwracająca id drużyny.
        public int getId()
        {
            return this.id;
        }
       
    }
}
