using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_KAPAKABANA
{
    class Siatkowka : Mecz
    {
        private SedziaPomocniczy sedziapom1;
        private SedziaPomocniczy sedziapom2;

        //Publiczny konstruktor 3-parametrowy klasy Siatkowka przyjmujący jako paramtery
        //id rozgrywki, 2 obiekty typu SędziaPomocniczy oraz wywołuje konstruktor klasy bazowej.
        public Siatkowka(int idd, SedziaPomocniczy s1, SedziaPomocniczy s2) : base(idd)
        {
            this.sedziapom1 = s1;
            this.sedziapom2 = s2;
        }
    }
}
