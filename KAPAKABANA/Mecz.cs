using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_KAPAKABANA
{
    class Mecz
    {
        private Druzyna druzyna1;
        private Druzyna druzyna2;
        private Sedzia sedzia;
        private int id;
        

        public Mecz(int idd)
        {
            this.id = idd;
        }

        public void UstawWygranego(int wynik1, int wynik2)
        {
            if (wynik1 > wynik2)
            {
                druzyna1.setLiczbaZwyciestw();
            }else if (wynik2 > wynik1)
            {
                druzyna2.setLiczbaZwyciestw();
            }
        }

        public void DodajDruzyne(Druzyna d)
        { 

        }
        public void DodajSedziego(Sedzia s)
        {

        }
    }
}
