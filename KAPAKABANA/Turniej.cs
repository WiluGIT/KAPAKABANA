using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PO_KAPAKABANA;

namespace KAPAKABANA
{

    class Turniej
    {
        private List<Mecz> lista_meczy = new List<Mecz>();
        private enum typTurnieju { PrzeciaganieLiny, DwaOgnie, Siatkowka };
        private int id;
        private Druzyna[] finalisci;
        

        public Turniej(int idd)
        {
            this.id = idd;
        }

        public void DodajDruzyne()
        {

        }
        public void DodajSedziego()
        {

        }

        public void UsunDruzyne(int idd)
        {

        }

        public void UsunSedziego(int idd)
        {

        }

        public void PrzegladDruzyn()
        {

        }

        public void PrzegladSedziow()
        {

        }

        public void StworzMecz()
        {

        }

        public void WypiszWyniki(List<Druzyna> lista_druzyn)
        {

        }

        public void GenerowanieFinalow()
        {

        }

        public void ZapisDoPliku(String nazwa)
        {

        }

        public void OdczytZPliku(String nazwa)
        {

        }

        public Druzyna[] WyborFinalistow(List<Druzyna> lista_druzyn)
        {
        
            return finalisci;
        }


    }
}
