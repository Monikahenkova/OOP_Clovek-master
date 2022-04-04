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
        public string Prohra { get; set; }

        //konstruktor - pomocí této metody vznikne konkrétní objekt - instance třídy
        public Clovek()
        {
            Jmeno = "";
            Prijmeni = "";
            DatumNarozeni = DateTime.Now;
            energie = 100;
            Zivot = 100;
            dovednost = 0;
            Prohra = "Žiješ";
        } 
        
        public void Zestarnout()
        {  
            if (Zivot > 0)
            {
                energie -= 20;
            if(energie < 0)
            {
                energie = 0;
            }
            Zivot -= 20;
            }
            else if (Zivot <= 0)
            {
                Prohra = "Seš tuhej." ;

            }
        }

        public void ZvysitDovednost()
        {
            if (Zivot > 0)
            {
                dovednost += 20;
            energie -= 15;
            if (energie < 0)
            {
                energie = 0;
            }
            Zivot -= 15;
            }
            else if (Zivot <= 0)
            {
                Prohra = "Seš tuhej.";

            }
        }
         
        public void PridatEnergii()
        {
            if (Zivot > 0)
            {
                energie += 30; 
            if (energie < 0)
            {
                energie = 0;
            }
            Zivot -= 30;
            }
            else if (Zivot <= 0)
            {
                Prohra = "Seš tuhej.";

            }
        }

        public void Spát()
        {
            if (Zivot > 0)
            {
                energie += 10;
            if (energie < 0)
            {
                energie = 0;
            }
            Zivot += 15;
            }
            else if (Zivot <= 0)
            {
                Prohra = "Seš tuhej.";

            }
        }

        public void Bojuj()
        {
            if (Zivot > 0)
            {
                dovednost += 15;
            energie -= 35;
            if (energie < 0)
            {
                energie = 0;
            }
            Zivot -= 10;
            }
            else if (Zivot <= 0)
            {
                Prohra = "Seš tuhej.";

            }
        }

        public void Utéct()
        {
            if (Zivot > 0)
            {
                energie -= 30;
            if (energie < 0)
            {
                energie = 0;
            }
            Zivot += 10;
            }
            else if (Zivot <= 0)
            {
                Prohra = "Seš tuhej.";

            }
        }

      
    }
}
