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
        public int Spánek { get; set; }
        public int Boj { get; set; }
        public int Útěk { get; set; }

        //konstruktor - pomocí této metody vznikne konkrétní objekt - instance třídy
        public Clovek()
        {
            Jmeno = "";
            Prijmeni = "";
            DatumNarozeni = DateTime.Now;
            energie = 100;
            Zivot = 100;
            dovednost = 0;
            Spánek = 0;
            Boj = 0;
            Útěk = 0;
        }
        
        public void Zestarnout()
        {
            energie -= 15;
            if(energie < 0)
            {
                energie = 0;
            }
            Zivot -= 10;
        }

        public void ZvysitDovednost()
        {
            dovednost += 20;
            energie -= 10;
        }
         
        public void PridatEnergii()
        {
            energie += 30;
            Zivot -= 10;

        }

        public void Spát()
        {
            energie += 15;
            Zivot += 5;
        }

        public void Bojuj()
        {
            energie -= 30;
            dovednost += 15;
        }

        public void Utéct()
        {
            energie -= 10;
            Zivot += 10;
        }
        
    }
}
