using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calendar
{
    public class Calendar
    {
        public enum lunaAnului
        {
            Ianuarie = 1,
            Februarie, Martie, Aprilie, Mai, Iunie, Iulie,
            August, Septembrie, Octombrie, Noiembrie, Decembrie
        }
        public string [] denumireaLunilorAnului = {"Ianuarie" ,
            "Februarie", "Martie", "Aprilie", "Mai", "Iunie", "Iulie",
            "August", "Septembrie", "Octombrie", "Noiembrie", "Decembrie"};

        public int[] numaruluiZilelorInFiecareLuna = { 31,28,31,30,31,30,31,31,30,31,30,31 };
        public int[] numaruluiZilelorInFiecareLunaInAnBisect = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public int nrZilelorAnului = 365;
        public int nrZilelorAnuluiBisect = 366;

        public int gasesteNumarulZilei(Calendar.lunaAnului x)
        {
            return (int)x;
        }

        public DateTime OraCurenta = DateTime.Now;
        public DateTime TimpCurent = DateTime.Now;

        public void UpdateazaOraCurenta()
        {
            OraCurenta = DateTime.Now;
        }
        public void UpdateazaTimpCurent()
        {
            TimpCurent = DateTime.Now;
        }

        public string afiseazaToateZileleSaptamanii()
        {
            String rez = "";
            for (int i = 0; i < denumireaLunilorAnului.Length; i++)
            {
                rez += denumireaLunilorAnului[i].ToString() + " : " + (i+1).ToString() + " , \r\n" ;
            }

            return rez;
        }

        public string afiseazaOraCurenta()
        {

            return OraCurenta.ToLongTimeString(); 

        }

        public string afiseazaDataCurenta()
        {

            return OraCurenta.Date.ToString();

        }

        public string afiseazaTimpulCurent()
        {
            string rez="";

            TimpCurent = DateTime.Now;
            int H = TimpCurent.Hour;
            int M = TimpCurent.Minute;
            int S = TimpCurent.Second;
            int MS = TimpCurent.Millisecond;

            rez += H + ":";
            rez += M + ":";
            rez += S + ":";
            rez += MS ;
          

            return rez;
        }

    }
}
