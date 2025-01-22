using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama14_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // genellikle listeleme işlemlerinde kullanılır
            // Array(Diziler): Aynı tipte birden fazla değeri saklamak için kullanılır.
            //Bri diziyi gezmek ve listelemek için foreach dizi elamnları ile ilgili islemler yapılacaksa for kullanılır

            //int[] sayilar = { 6, 10, 15, 20, 4, 8 };
            //int[] sayilar2 = new int[5];
            //sayilar2[0] = 23;
            //sayilar2[1] = 12;
            //sayilar2[2] = 12;
            //sayilar2[3] = 12;
            //sayilar2[4] = 12;
            //Console.WriteLine(sayilar2[4]);
            int[] sayilar = { 6, 10, 15, 20, 4, 8 };
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }

            int[] sayilar2 = new int[5];
           
            for(int i=0;i<sayilar2.Length;i++)
            {
                Console.WriteLine("sayı giriniz");
                sayilar2[i]=Convert.ToInt32(Console.ReadLine());
            }

            foreach(int i in sayilar2)
            {
                Console.WriteLine("dizi elamanı: "+i);
            }

            string ad = "serap";
            Console.WriteLine(ad[2]);

            foreach (char i in ad)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
