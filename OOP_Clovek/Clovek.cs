using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Clovek
{
    public class Clovek
    {
        // soukromé proměnné - nejsou dostupné mimo třídu Clovek
        private int energie;
        private int dovednost;

        // vlastnosti - zveřejňují hodnoty ven z třídy
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public int Energie { get => energie; }
        public int Zivot { get; set; }
        public int Dovednost { get => dovednost; }
        public int Spánek { get => energie; }
        public int Lenost { get; set; }
        public int Bojovat { get => dovednost; }

        //konstruktor - pomocí této metody vznikne konkrétní objekt - instance třídy
        public Clovek()
        {
            Jmeno = "";
            Prijmeni = "";
            DatumNarozeni = DateTime.Now;
            energie = 100;
            Zivot = 100;
            dovednost = 0;
            Lenost = 0;
        }
        
        public void Zestarnout()
        {
            energie -= 10;
            if(energie < 0)
            {
                energie = 0;
            }
            Zivot += 2;
        }

        public void ZvysitDovednost()
        {
            dovednost += 20;
            energie += 10;
        }
         
        public void PridatEnergii()
        {
            energie += 30;
            if(energie < 100)
            {
                energie = 0;
            }
            Zivot -= 1;
        }

        public void Spát()
        {
            energie += 15;
            Lenost += 25;
            dovednost -= 5;
        }

        public void Bojovat()
        {
            energie -= 50;
            Lenost -= 10;
            Zivot -= 1;
            dovednost += 5;
        }


    }
}
