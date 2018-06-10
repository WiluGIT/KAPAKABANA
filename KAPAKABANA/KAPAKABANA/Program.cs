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
            Turniej turniej = new Turniej(rnd.Next(0, 10000));
            int odp=1;
            int odp2=0;
            while (odp2 != 1)
            {
                Console.WriteLine("Menu\n1.Rozpocznij turniej.\n2.Wyjście z programu.");
                odp2 = Convert.ToInt32(Console.ReadLine());
                switch (odp2)
                {
                    case 1: Console.Clear();
                        Console.WriteLine("Podaj typ turnieju:\n1-Przeciaganie liny\n2-Dwa Ognie\n3-Siatkowka");
                        int wybor = Convert.ToInt32(Console.ReadLine());
                        turniej.UstawTyp(wybor);
                        turniej.wypisztyp();
                        break;
                    case 2:
                        Environment.Exit();
                    default: Console.WriteLine("Nie ma takiej opcji");
                        break;
                }

            }
            while (odp != 0)
            {
                Console.WriteLine("Menu\n1.Stworz mecz w turnieju.\n2.Dodaj druzyne do turnieju.\n3.Dodaj sedziego.\n5.Przeglad druzyn.\n6.Przeglad sedziow.");
                odp = Convert.ToInt32(Console.ReadLine());
                switch (odp)
                {
                    case 1: Console.Clear();
                        turniej.StworzMecz();
                        break;
                    case 2: Console.Clear();
                        turniej.DodajDruzyne();
                        break;
                    case 3: Console.Clear();
                        turniej.DodajSedziego();
                        break;
                    case 5: Console.Clear();
                        turniej.PrzegladDruzyn();
                        break;
                    case 6: Console.Clear();
                        turniej.PrzegladSedziow();
                        break;
                    case 0: break;
                    default: Console.WriteLine("Nie ma takiej opcji");
                        break;
                }
            }
        }
    }
}
