using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "JAVA";
            kurs1.Egitmen = "Kerem";
            kurs1.IzlenmeOrani = 34;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Berkay";
            kurs2.IzlenmeOrani = 89;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.Egitmen = "Ahmet";
            kurs3.IzlenmeOrani = 68;

            //Console.WriteLine(kurs1.KursAdi + "" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].KursAdi + " " + kurslar[i].Egitmen + " " + kurslar[i].IzlenmeOrani+"\n");
            }

            Console.WriteLine("--------------------------------------------------------------------------------------");

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı: "+kurs.KursAdi+"| Kurs Egitmeni: "+kurs.Egitmen+"| Izlenme Orani: "+kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public  string KursAdi { get; set; }

        public  string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
