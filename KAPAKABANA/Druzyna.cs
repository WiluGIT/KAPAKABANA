﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAPAKABANA
{
    class Druzyna
    {
        private string nazwa;
        private int id;
        private int liczbaZwyciestw = 0;

        public Druzyna(string nazw, int idd)
        {
            this.nazwa = nazw;
            this.id = idd;
        }
        public void setLiczbaZwyciestw()
        {
            this.liczbaZwyciestw++;
        }
        public int getLiczbaZwyciestw()
        {
            return this.liczbaZwyciestw;
        }
    }
}
