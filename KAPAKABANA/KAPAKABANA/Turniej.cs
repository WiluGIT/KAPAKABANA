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
        public enum typTurnieju { PrzeciaganieLiny=1, DwaOgnie, Siatkowka };
        private int id;
        private Druzyna[] finalisci = new Druzyna[4];
        Random rnd = new Random();
        private typTurnieju typ;
        private Druzyna[] final = new Druzyna[2];
        
        //Publiczny konstruktor 2-parametrowy przyjmujący 2 parametry typu int.
        //Ustawia prywatne pola klasy.
        public Turniej(int idd, int typ_)
        {
            this.id = idd;
            this.typ = (typTurnieju)typ_;
        }

        //Publiczna metoda zwracająca listę wszystkich meczy w turnieju.
        public List<Mecz> getMecze()
        {
            return this.lista_meczy;
        }

        //Publiczna metoda zwracająca listę wszystkich sędziów w turnieju.
        public List<Sedzia> getSedzie()
        {
            return this.lista_allSedziow;
        }

        //Publiczna metoda zwracająca listę wszystkich drużyn w turnieju.
        public List<Druzyna> getDruzyny()
        {
            return this.lista_allDruzyn;
        }

        //Publiczna metoda tworząca obiekt typu Druzyna i dodająca go do listy wszystkich drużyn w turnieju.
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

        //Publiczna metoda tworząca obiekt typu Sedzia i dodająca go do listy wszystkich sędziów w turnieju.
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

        //Publiczna metoda przyjmująca parametr typu int. 
        //Wyszukuje drużynę o podanym jako parametr id i usuwa ją z listy wszystkich drużyn w turnieju.
        public void UsunDruzyne(int idd)
        {
            Druzyna dr = lista_allDruzyn.Find(d => d.getId().Equals(idd));
            lista_allDruzyn.Remove(dr);
        }

        //Publiczna metoda przyjmująca parametr typu int.
        //Wyszukuje sędziego o podanym jako parametr id i usuwa go z listy wszystkich sędziów w turnieju.
        public void UsunSedziego(int idd)
        {
            Sedzia se = lista_allSedziow.Find(s => s.getId().Equals(idd));
            lista_allSedziow.Remove(se);
        }

        //Publiczna metoda wypisująca na ekran dane o każdej drużynie znajdującej się na liście wszystkich drużyn w turnieju.
        public void PrzegladDruzyn()
        {
            foreach(Druzyna d in lista_allDruzyn)
            {
                Console.WriteLine("Nazwa druzyny: {0} ID druzyny: {1} ",d.getNazwa(),d.getId());

                Console.WriteLine("---------------------------------------------------------------");
            }
        }

        //Publiczna metoda wypisująca na ekran dane o każdym sędzim znajdującym się na liście wszystkich sędziów w turnieju
        public void PrzegladSedziow()
        {
            foreach(Sedzia s in lista_allSedziow)
            {
                Console.WriteLine("Imie sedziego: {0} Nazwisko sedziego: {1} Id sedziego: {2}",s.getImie(),s.getNazwisko(),s.getId());
                Console.WriteLine("--------------------------------------------------------------");
            }

        }

        //Publiczna metoda, która na podstawie typu stworzonego turnieju tworzy obiekty rozgrywek
        //o tym typie i dodaje je do listy wszystkich meczy w turnieju. 
        //Dodatkowo dla typu Siatkówka tworzeni są dwaj sędziowie pomocniczy i dodani do listy wszystkich sędziów w turnieju.
        public void StworzMecz()
        {

            String s1, s2, n1, n2;
            int i1, i2;
            switch (typ)
            {
                case typTurnieju.PrzeciaganieLiny: PrzeciaganieLiny przeciaganieLiny = new PrzeciaganieLiny(rnd.Next());
                    lista_meczy.Add(przeciaganieLiny);
                    break;
                case typTurnieju.DwaOgnie: DwaOgnie dwaOgnie = new DwaOgnie(rnd.Next());
                    lista_meczy.Add(dwaOgnie);
                    break;
                case typTurnieju.Siatkowka: Console.WriteLine("Podaj imie sedziego pomocniczego: ");
                    n1 = Console.ReadLine();
                    Console.WriteLine("Podaj nazwisko sedziego pomocniczego: ");
                    s1 = Console.ReadLine();
                    Console.WriteLine("Podaj id sedziego pomocniczego: ");
                    i1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj imie sedziego pomocniczego: ");
                    n2 = Console.ReadLine();
                    Console.WriteLine("Podaj nazwisko sedziego pomocniczego: ");
                    s2 = Console.ReadLine();
                    Console.WriteLine("Podaj id sedziego pomocniczego: ");
                    i2 = int.Parse(Console.ReadLine());
                    SedziaPomocniczy sp1 = new SedziaPomocniczy(n1, s1, i1);
                    SedziaPomocniczy sp2 = new SedziaPomocniczy(n2, s2, i2);
                    Siatkowka siatkowka = new Siatkowka(rnd.Next(),sp1,sp2);
                    lista_meczy.Add(siatkowka);
                    lista_allSedziow.Add(sp1);
                    lista_allSedziow.Add(sp2);
                    break;
            }

        }

        //Publiczna metoda wypisująca nazwę drużyny i odpowiadającą jej liczbę zwycięstw.
        public void WypiszWyniki()
        {
            foreach(Druzyna d in lista_allDruzyn)
            {
                Console.WriteLine("Liczba zwyciestw druzyny {0} = {1}", d.getNazwa(), d.getLiczbaZwyciestw());


            }
        }

        //Publiczna metoda wypisująca na ekran dane o wszystkich meczach w turnieju.
        public void WypiszMecze()
        {
            foreach (Mecz m in lista_meczy)
            {
                Console.WriteLine(m.getId() + " " + m.getDruzyny()[0].getNazwa() + " " + m.getDruzyny()[1].getNazwa() + " " + m.getSedzie()[0].getId());
            }
        }

        //Publiczna metoda wybierająca spośród 4 drużyn, znajdujących się w tablicy finaliści, dwie które przechodzą do finału.
        //Zostają one dodane do tablicy finał. Wybór odbywa się za pośrednictwem użytkownika.
        public void GenereowaniePolFinalow()
        {

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine((i + 1) + ".Mecz polfinalowy zagra druzyna {0} z {1} ", finalisci[i].getNazwa(), finalisci[i + 2].getNazwa());
                Console.WriteLine("Podaj zwyciezce: ");
                Console.WriteLine("1 - {0}", finalisci[i].getNazwa());
                Console.WriteLine("2 - {0}", finalisci[i + 2].getNazwa());
                int wybor1 = int.Parse(Console.ReadLine());
                if (wybor1 == 1)
                {
                    finalisci[i].setLiczbaZwyciestw();
                    final[i] = finalisci[i];
                }
                else if (wybor1 == 2)
                {
                    finalisci[i + 2].setLiczbaZwyciestw();
                    final[i] = finalisci[i + 2];
                }
                else
                {
                    Console.WriteLine("Zly wybor");
                }
            }

        }

        //Publiczna metoda wybierająca spośród dwóch finalistów jednego, który wygrywa turniej. 
        //Wybór odbywa się za pośrednictwem użytkownika
        public void GenerowanieFinalow()
        {
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

        //Publiczna metoda zapisująca dane o turnieju do pliku tekstowego.
        //Przyjmuje jako parametry nazwę pliku oraz rodzaj listy, z której mają być odczytane dane.
        public void ZapisDoPliku(String nazwa, int rodzaj_listy)
        {

            StreamWriter sw = new StreamWriter(nazwa);
            switch (rodzaj_listy)
            {
                case 1:
                    for (int i = 0; i < lista_allDruzyn.Count(); i++)
                    {
                        sw.WriteLine(lista_allDruzyn[i].getNazwa() + " " + lista_allDruzyn[i].getId() + " " + lista_allDruzyn[i].getLiczbaZwyciestw());
                    }
                    break;
                case 2:
                    for (int i = 0; i < lista_allSedziow.Count(); i++)
                    {
                        sw.WriteLine(lista_allSedziow[i].getImie() + " " + lista_allSedziow[i].getNazwisko() + " " + lista_allSedziow[i].getId());
                    }
                    break;
                case 3:
                    for (int i = 0; i < lista_meczy.Count(); i++)
                    {
                        sw.WriteLine(lista_meczy[i].getId() + " " + lista_meczy[i].getDruzyny()[0].getNazwa() + " " + lista_meczy[i].getDruzyny()[1].getNazwa() + " " + lista_meczy[i].getSedzie()[0].getId());
                    }
                    break;
            }
            sw.Close();
        }

        //Publiczna metoda odczytująca dane z pliku tekstowego do programu.
        //Przyjmuje jako parametry nazwę pliku oraz rodzaj listy do której mają być zapisane dane.
        public void OdczytZPliku(String nazwa, int rodzaj_listy)
        {
            StreamReader sr = new StreamReader(nazwa);
            String linia;
            switch (rodzaj_listy)
            {
                case 1:
                    Druzyna tmp1;
                    while ((linia = sr.ReadLine()) != null)
                    {
                        string[] s = linia.Split(null);
                        tmp1 = new Druzyna(s[0], int.Parse(s[1]));
                        for (int i = 0; i < int.Parse(s[2]); i++)
                        {
                            tmp1.setLiczbaZwyciestw();
                        }
                        lista_allDruzyn.Add(tmp1);
                    }
                    break;
                case 2:
                    Sedzia tmp2;
                    while ((linia = sr.ReadLine()) != null)
                    {
                        string[] s = linia.Split(null);
                        tmp2 = new Sedzia(s[0], s[1], int.Parse(s[2]));
                        lista_allSedziow.Add(tmp2);
                    }
                    break;
                case 3:
                    Mecz tmp3;
                    while ((linia = sr.ReadLine()) != null)
                    {
                        string[] s = linia.Split(null);
                        tmp3 = new Mecz(int.Parse(s[0]));
                        foreach (Druzyna d in lista_allDruzyn)
                        {
                            if (d.getNazwa() == s[1])
                                tmp3.DodajDruzyne(d);
                        }
                        foreach (Druzyna d in lista_allDruzyn)
                        {
                            if (d.getNazwa() == s[2])
                                tmp3.DodajDruzyne(d);
                        }
                        foreach (Sedzia se in lista_allSedziow)
                        {
                            if (se.getId() == int.Parse(s[3]))
                                tmp3.DodajSedziego(se);
                        }
                        lista_meczy.Add(tmp3);
                    }
                    break;
            }
            sr.Close();
        }

        //Publiczna metoda sortująca listę drużyn malejąco na podstawie liczy zwycięstw.
        //Dodaje cztery pierwsze wyniki do tablicy finaliści.
        public void WyborFinalistow()
        {
            List<Druzyna> tmp = new List<Druzyna>();
            tmp = lista_allDruzyn.OrderByDescending(d => d.getLiczbaZwyciestw()).ToList();
            for(int i = 0; i < 4; i++)
            {
                finalisci[i] = tmp[i];
            }
        }

        //Publiczna metoda zwracająca id turnieju.
        public int getId()
        {
            return this.id;
        }
    }
}
