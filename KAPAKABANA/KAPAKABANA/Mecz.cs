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

        private List<Druzyna> dwieDruzyny = new List<Druzyna>();
        private Sedzia[] sedziaTab = new Sedzia[1];
        

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
            dwieDruzyny.Add(d);
        }
        public void DodajSedziego(Sedzia s)
        {
            sedziaTab[0] = s;
        }
    }
}
