using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖĞRENCİ_DERS_GECME_PROJESİ
{

    class Ders
    {
        private string dersAd;
        private double gecmenot = 50;

        public string DersAd
        {
            get { return dersAd; }
            set { dersAd = value; }
        }

        public double GecmeNot
        {
            get { return gecmenot; }
            set { gecmenot = value; }
        }
        public virtual double GecmeHesapla()
        {
            return GecmeNot * 1;
        }        
    }
    class Matematik : Ders
    {
        public override double GecmeHesapla()
        {
            return GecmeNot *1.2;
        }
    }
    class Fizik : Ders
    {
        public override double GecmeHesapla()
        {
            return GecmeNot*1.1;
        }
    }
    class Beden : Ders
    {
        public override double GecmeHesapla()
        {
            return GecmeNot*0.9; 
        }
    }
}
