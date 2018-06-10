using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PO_KAPAKABANA;

namespace KAPAKABANA
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Jaki typ turnieju chcialbys stworzyc ?\n1.Przeciaganie Liny\n2.Dwa Ognie\n3.Siatkowka");
            int wybor = Convert.ToInt32(Console.ReadLine());
            Turniej turniej = new Turniej(rnd.Next(0, 10000),wybor);
            int odp=1,a = 0, wynik1,wynik2;
            while (odp != 0)
            {
                Console.WriteLine("Menu.\n1.Dodaj druzyne do turnieju.\n2.Dodaj sedziego.\n3.Przeglad druzyn.\n4.Przeglad sedziow.\n5.Przeglad wynikow.\n6.Przeglad meczy\n7.Usun druzyne.\n8.Usun sedziego.\n9.Zapisz danych do pliku.\n10.Odczyt danych z pliku\n11.Rozpocznij turniej\n0.Wyjdz z programu");
                odp = Convert.ToInt32(Console.ReadLine());
                switch (odp)
                {
                    case 1:
                        Console.Clear();
                        turniej.DodajDruzyne();
                        break;
                    case 2:
                        Console.Clear();
                        turniej.DodajSedziego();
                        break;
                    case 3:
                        Console.Clear();
                        turniej.PrzegladDruzyn();
                        break;
                    case 4:
                        Console.Clear();
                        turniej.PrzegladSedziow();
                        break;
                    case 5:
                        Console.Clear();
                        turniej.WypiszWyniki();
                        break;
                    case 6: Console.Clear();
                        turniej.WypiszMecze();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Podaj id usuwanej druzyny:");
                        int idChocie = int.Parse(Console.ReadLine());
                        turniej.UsunDruzyne(idChocie);
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Podaj id usuwanego sedziego:");
                        int idChoice2 = int.Parse(Console.ReadLine());
                        turniej.UsunSedziego(idChoice2);
                        break;
                    case 9:
                        Console.WriteLine("Podaj nazwe pliku:");
                        string fileName = Console.ReadLine();
                        Console.WriteLine("Podaj rodzaj do zapisu\n1.Druzyna\n2.Sedzie\n3.Mecze");
                        int rodzaj_doZapisu = Convert.ToInt32(Console.ReadLine());
                        turniej.ZapisDoPliku(fileName,rodzaj_doZapisu);
                        break;
                    case 10:
                        Console.WriteLine("Podaj nazwe pliku");
                        string fileName2 = Console.ReadLine();
                        Console.WriteLine("Podaj rodzaj do odczytu\n1.Druzyna\n2.Sedzie\n3.Mecze");
                        int rodzaj_doOdczytu = Convert.ToInt32(Console.ReadLine());
                        turniej.OdczytZPliku(fileName2,rodzaj_doOdczytu);
                        break;
                    case 11:
                        if (turniej.getDruzyny().Count() < 4) {
                            Console.WriteLine("Za mala liczba druzyn");
                            break;
                        }
                        for (int i = 0; i < turniej.getDruzyny().Count(); i++)
                        {
                            for (int j = i+1; j < turniej.getDruzyny().Count(); j++)
                            {
                                turniej.StworzMecz();
                                turniej.getMecze()[a].DodajDruzyne(turniej.getDruzyny()[i]);
                                turniej.getMecze()[a].DodajDruzyne(turniej.getDruzyny()[j]);
                                turniej.getMecze()[a].DodajSedziego(turniej.getSedzie()[rnd.Next(0,turniej.getSedzie().Count())]);
                                Console.WriteLine("Podaj wynik pierwszej druzyny " + turniej.getMecze()[a].getDruzyny()[0].getNazwa());
                                wynik1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Podaj wynik drugiej druzyny " + turniej.getMecze()[a].getDruzyny()[1].getNazwa());
                                wynik2 = Convert.ToInt32(Console.ReadLine());
                                turniej.getMecze()[a].UstawWygranego(wynik1, wynik2);
                                a++;
                            }
                        }
                        turniej.WyborFinalistow();
                        turniej.GenereowaniePolFinalow();
                        turniej.GenerowanieFinalow();
                        break;
                    case 0: break;
                    default:
                        Console.WriteLine("Nie ma takiej opcji");
                        break;
                }
            }   
        }
    }
}
