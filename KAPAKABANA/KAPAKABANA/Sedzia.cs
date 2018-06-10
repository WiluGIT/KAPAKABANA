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

        public Sedzia(string name, string surname, int idd)
        {
            this.imie = name;
            this.nazwisko = surname;
            this.id = idd;
        }
        public string getImie()
        {
            return this.imie;
        }
        public string getNazwisko()
        {
            return this.nazwisko;
        }
        public int getId()
        {
            return this.id;
        }
    }
}
