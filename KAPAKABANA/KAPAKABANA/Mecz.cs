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

        //publiczna metoda zwracająca prywatne pole id.
        public int getId()
        {
            return this.id;
        }

        //publiczna metoda zwracająca prywatną listę typu Druzyna.
        public List<Druzyna> getDruzyny()
        {
            return this.dwieDruzyny;
        }

        //publiczna metoda zwracająca prywatną tablicę typu Sedzia.
        public Sedzia[] getSedzie()
        {
            return this.sedziaTab;
        }

        //Konstruktor 1-parametrowy klasy Mecz przyjmujący parametr typu int.
        public Mecz(int idd)
        {
            this.id = idd;
        }

        //Publiczna metoda przyjmująca 2 parametry
        //będące wynikami rozegranego meczu. Na ich podstawie
        //ustalany jest zwycięzca meczu oraz zostaje zwiększona jego liczba zwycięstw.
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

        //Publiczna metoda przyjmująca parametr typu Druzyna.
        //Dodaje otrzymaną drużynę do listy drużyn meczu.
        public void DodajDruzyne(Druzyna d)
        {
            dwieDruzyny.Add(d);
        }

        //Publiczna metoda przyjmująca parametr typu Sedzia.
        //Dodaje otrzymanego sędziego do tablicy sędziów meczu.
        public void DodajSedziego(Sedzia s)
        {
            sedziaTab[0] = s;
        }
    }
}
