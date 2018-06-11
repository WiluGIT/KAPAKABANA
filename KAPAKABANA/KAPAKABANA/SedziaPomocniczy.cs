using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_KAPAKABANA
{
    class SedziaPomocniczy : Sedzia
    {
        //Publiczny konstruktor 3-paramterowy klasy SedziaPomocniczy przyjmujący 2 parametry
        //typu string oraz 1 typu int. Wywołuje również konstruktor klasy bazowej.
        public SedziaPomocniczy(string name, string surname, int id) : base(name, surname, id)
        {

        }
    }
}
