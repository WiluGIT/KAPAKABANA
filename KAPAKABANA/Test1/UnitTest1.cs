using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PO_KAPAKABANA;
using KAPAKABANA;

namespace Test1
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestLiczbaZwyciestw()
        {
            Druzyna druzyna = new Druzyna("testowa", 2);

            druzyna.setLiczbaZwyciestw();
            int wynik = druzyna.getLiczbaZwyciestw();

            Assert.AreEqual(1, wynik);
        }
        [TestMethod]
        public void TestUstawWynik()
        {
            Druzyna druzyna1 = new Druzyna("Janusz", 2137);
            Druzyna druzyna2 = new Druzyna("Pawlacz", 1337);
            Mecz mecz = new Mecz(911);
            mecz.DodajDruzyne(druzyna1);
            mecz.DodajDruzyne(druzyna2);

            mecz.UstawWygranego(10, 4);

            int wynik = druzyna1.getLiczbaZwyciestw();

            Assert.AreEqual(1, wynik);
        }
        [TestMethod]
        public void TestWyborFinalistow()
        {
            Druzyna druzyna1 = new Druzyna("aa",1);
            Druzyna druzyna2 = new Druzyna("bb", 2);
            Druzyna druzyna3 = new Druzyna("cc", 3);
            Druzyna druzyna4 = new Druzyna("dd", 4);
            Druzyna druzyna5 = new Druzyna("ee", 5);
            Turniej turniej = new Turniej(1, 1);

            turniej.getDruzyny().Add(druzyna1);
            turniej.getDruzyny().Add(druzyna2);
            turniej.getDruzyny().Add(druzyna3);
            turniej.getDruzyny().Add(druzyna4);
            turniej.getDruzyny().Add(druzyna5);

            for(int x=0;x<5;x++)
            {
                druzyna1.setLiczbaZwyciestw();
            }
            for (int x = 0; x < 7; x++)
            {
                druzyna2.setLiczbaZwyciestw();
            }
            for (int x = 0; x < 3; x++)
            {
                druzyna3.setLiczbaZwyciestw();
            }
            for (int x = 0; x < 2; x++)
            {
                druzyna4.setLiczbaZwyciestw();
            }
            for (int x = 0; x < 15; x++)
            {
                druzyna5.setLiczbaZwyciestw();
            }

            turniej.WyborFinalistow();
            Druzyna[] f = turniej.getFinalisci();

            Assert.AreEqual(druzyna5.getNazwa(),f[0].getNazwa());
            Assert.AreEqual(druzyna2.getNazwa(), f[1].getNazwa());
            Assert.AreEqual(druzyna1.getNazwa(), f[2].getNazwa());
            Assert.AreEqual(druzyna3.getNazwa(), f[3].getNazwa());

        }
    }
}
