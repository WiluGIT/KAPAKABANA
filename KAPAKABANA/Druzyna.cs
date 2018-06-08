using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_KAPAKABANA
{
    class Druzyna
    {
        private string nazwa;
        private int id;
        private int liczbaZwyciestw = 0;

        public Druzyna(string nazw, int idd)
        {
            this.nazwa = nazw;
            this.id = idd;
        }
        public void setLiczbaZwyciestw()
        {
            this.liczbaZwyciestw++;
        }
    }
}
