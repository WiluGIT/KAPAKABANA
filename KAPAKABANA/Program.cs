using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KAPAKABANA
{
    class Program
    {
        static void Main(string[] args)
        {
            Turniej turniej = new Turniej(0,Turniej.typTurnieju.Siatkowka);
            Console.WriteLine(""+turniej.typ);
            turniej.StworzMecz("a", "b", "1", "2");
        }
    }
}
