using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_KAPAKABANA
{
    class Mecz
    {

        private int id;

        private List<Druzyna> dwieDruzyny = new List<Druzyna>();
        private Sedzia[] sedziaTab = new Sedzia[1];
        public int getId()
        {
            return this.id;
        }
        public List<Druzyna> getDruzyny()
        {
            return this.dwieDruzyny;
        }
        public Sedzia[] getSedzie()
        {
            return this.sedziaTab;
        }

        public Mecz(int idd)
        {
            this.id = idd;
        }

        public void UstawWygranego(int wynik1, int wynik2)
        {
            if (wynik1 > wynik2)
            {
                dwieDruzyny[0].setLiczbaZwyciestw();
            }else if (wynik2 > wynik1)
            {
                dwieDruzyny[1].setLiczbaZwyciestw();
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
