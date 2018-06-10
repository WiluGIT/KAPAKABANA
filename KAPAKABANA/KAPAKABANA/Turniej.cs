using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


using PO_KAPAKABANA;


namespace KAPAKABANA
{

    class Turniej
    {
        private List<Mecz> lista_meczy = new List<Mecz>();
        private List<Druzyna> lista_allDruzyn = new List<Druzyna>();
        private List<Sedzia> lista_allSedziow = new List<Sedzia>();
        private enum typTurnieju { PrzeciaganieLiny, DwaOgnie, Siatkowka };
        private int id;
        private Druzyna[] finalisci = new Druzyna[4];
        

        public Turniej(int idd)
        {
            this.id = idd;
        }

        public void DodajDruzyne()
        {
            string name;
            int idDruzyny;

            Console.WriteLine("Podaj id druzyny: ");
            idDruzyny = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj nazwe druzyny: ");
            name = Console.ReadLine();
            Druzyna dTmp = new Druzyna(name, idDruzyny);
            lista_allDruzyn.Add(dTmp);


        }
        public void DodajSedziego()
        {
            string name;
            string surname;
            int idSedziego;
            Console.WriteLine("Podaj imie sedziego: ");
            name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko sedziego: ");
            surname = Console.ReadLine();
            Console.WriteLine("Podaj id sedziego: ");
            idSedziego = int.Parse(Console.ReadLine());

            Sedzia sTmp = new Sedzia(name, surname, idSedziego);
            lista_allSedziow.Add(sTmp);

        }

        public void UsunDruzyne(int idd)
        {
            lista_allDruzyn.RemoveAt(idd);
        }

        public void UsunSedziego(int idd)
        {
            lista_allSedziow.RemoveAt(idd);
        }

        public void PrzegladDruzyn()
        {
            foreach(Druzyna d in lista_allDruzyn)
            {
                Console.WriteLine("Nazwa druzyny: {0} ID druzyny: {1} ",d.getNazwa(),d.getId());

                Console.WriteLine("---------------------------------------------------------------");
            }
        }

        public void PrzegladSedziow()
        {
            foreach(Sedzia s in lista_allSedziow)
            {
                Console.WriteLine("Imie sedziego: {0} Nazwisko sedziego: {1} Id sedziego: {2}",s.getImie(),s.getNazwisko(),s.getId());
                Console.WriteLine("--------------------------------------------------------------");
            }

        }

        public void StworzMecz()
        {
            Console.WriteLine("Podaj typ meczu który chcesz stworzyc:");
            Console.WriteLine("1.Siatkowka");
            Console.WriteLine("2.Dwa Ognie");
            Console.WriteLine("3.Przeciaganie Liny");
            int wybor= int.Parse(Console.ReadLine());
            


        }

        public void WypiszWyniki()
        {
            foreach(Druzyna d in lista_allDruzyn)
            {
                Console.WriteLine("Liczba zwyciestw druzyny {0} = {1}", d.getNazwa(), d.getLiczbaZwyciestw());


            }
        }

        public void GenerowanieFinalow()
        {
            Console.WriteLine("Pierwszy mecz polfinalowy zagra druzyna {0} z {1} ", finalisci[0].getNazwa(), finalisci[1].getNazwa());
            Console.WriteLine("Podaj zwyciezce: ");
            Console.WriteLine("1 - {0}", finalisci[0].getNazwa());
            Console.WriteLine("2 - {0}", finalisci[1].getNazwa());
            Druzyna[] final = new Druzyna[2];
            int wybor1 = int.Parse(Console.ReadLine());
            if(wybor1==1)
            {
                finalisci[0].setLiczbaZwyciestw();
                final[0] = finalisci[0];
            }
            else if(wybor1==2)
            {
                finalisci[1].setLiczbaZwyciestw();
                final[0] = finalisci[1];
            }
            else
            {
                Console.WriteLine("Zly wybor");
            }


            Console.WriteLine("Drugi mecz polfinalowy zagra druzyna {0} z {1} ", finalisci[2].getNazwa(), finalisci[3].getNazwa());
            Console.WriteLine("Podaj zwyciezce: ");
            Console.WriteLine("1 - {0}", finalisci[2].getNazwa());
            Console.WriteLine("2 - {0}", finalisci[3].getNazwa());
            
            int wybor2 = int.Parse(Console.ReadLine());
            if (wybor2 == 1)
            {
                finalisci[2].setLiczbaZwyciestw();
                final[1] = finalisci[2];
            }
            else if (wybor2 == 2)
            {
                finalisci[3].setLiczbaZwyciestw();
                final[1] = finalisci[3];
            }
            else
            {
                Console.WriteLine("Zly wybor");
            }


            Console.WriteLine("Final gra {0} z {1} ", final[0].getNazwa(), final[1].getNazwa());
            Console.WriteLine("Podaj zwyciezce: ");
            Console.WriteLine("1 - {0}", final[0].getNazwa());
            Console.WriteLine("2 - {0}", final[1].getNazwa());
            
            int wybor3 = int.Parse(Console.ReadLine());
            if (wybor3 == 1)
            {
                final[0].setLiczbaZwyciestw();
                Console.WriteLine("Turniej wygrywa druzyna: {0}", final[0].getNazwa());
                
            }
            else if (wybor3 == 2)
            {
                final[1].setLiczbaZwyciestw();
                Console.WriteLine("Turniej wygrywa druzyna: {0}", final[1].getNazwa());
            }
            else
            {
                Console.WriteLine("Zly wybor");
            }

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
