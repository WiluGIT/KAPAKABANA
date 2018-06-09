using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;




namespace KAPAKABANA
{

    class Turniej
    {
        private List<Mecz> lista_meczy = new List<Mecz>();
        private int id;
        public  enum typTurnieju { PrzeciaganieLiny, DwaOgnie, Siatkowka };
        private Druzyna[] finalisci = new Druzyna[4];
        Random rnd = new Random();
        public typTurnieju typ;

        public List<Mecz> getListeMeczy()
        {
            return lista_meczy;
        }

        public Turniej(int idd, typTurnieju typ_)
        {
            this.id = idd;
            this.typ = typ_;
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

        public void StworzMecz(String imie1="",String nazwisko1="",String imie2="",String nazwisko2="")
        {
            switch (typ)
            {
                case typTurnieju.PrzeciaganieLiny: PrzeciaganieLiny przeciaganieLiny = new PrzeciaganieLiny(rnd.Next());
                    lista_meczy.Add(przeciaganieLiny);
                    break;
                case typTurnieju.DwaOgnie: DwaOgnie dwaOgnie = new DwaOgnie(rnd.Next());
                    lista_meczy.Add(dwaOgnie);
                    break;
                case typTurnieju.Siatkowka: Siatkowka siatkowka = new Siatkowka(rnd.Next(), new SedziaPomocniczy(imie1, nazwisko1, rnd.Next()), new SedziaPomocniczy(imie2, nazwisko2, rnd.Next()));
                    lista_meczy.Add(siatkowka);
                    break;
            }
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
            StreamReader sr = new StreamReader(nazwa);
            String line;
            while((line = sr.ReadLine())!= null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
        }

        public Druzyna[] WyborFinalistow(List<Druzyna> lista_druzyn)
        {
            lista_druzyn.OrderByDescending(d => d.getLiczbaZwyciestw());
            for(int i = 0; i < 4; i++)
            {
                finalisci[i] = lista_druzyn[i];
            }
            return finalisci;
        }


    }
}
