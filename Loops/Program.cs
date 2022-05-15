using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangı. için temek kurs";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetistirme Kampi", "Programlamaya Başlangıc için temek kurs", "Java" ,"Python","C#"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti \n");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
