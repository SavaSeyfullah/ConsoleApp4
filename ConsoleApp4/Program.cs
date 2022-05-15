using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Ayarlar Buton");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else if (dolarBugun == dolarBugun)
            {
                Console.WriteLine("Değişmedi");
            }






            Console.WriteLine(kategoriEtiketi);
        }
    }
}
