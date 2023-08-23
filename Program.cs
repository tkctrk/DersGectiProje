using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖĞRENCİ_DERS_GECME_PROJESİ
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MATEMATİK NOTUNUZU GİRİNİZ");
            double matnot = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("FİZİK NOTUNUZU GİRİNİZ");
            double fiziknot = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("BEDEN NOTUNUZU GİRİNİZ");
            double bedennot = Convert.ToDouble(Console.ReadLine());

            List<string> ifadelist = new List<string>();

            double matgecmenot = new Matematik().GecmeHesapla();           
            string Matİfade = matnot > matgecmenot ? "MATEMATİKTEN GECTİNİZ" : "MATEMATİKTEN KALDINIZ";
            ifadelist.Add(Matİfade);
            double fizikgecmenot= new Fizik().GecmeHesapla();
            string Fizikİfade = fiziknot > fizikgecmenot ? "FİZİKTEN GEÇTİNİZ" : "FİZİKTEN KALDINIZ";
            ifadelist.Add(Fizikİfade);
            double bedengecmenot = new Beden().GecmeHesapla();
            string bedenİfade = bedennot > bedengecmenot ? "BEDENDEN GECTİNİZ" : "BEDENDEN KALDINIZ";
            ifadelist.Add(bedenİfade);

            foreach (var item in ifadelist)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();



        }
    }
}
