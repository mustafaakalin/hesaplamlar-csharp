using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplamlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //karar kontrol mekanizmaları
            // if else, swich case
            //Girilen iki notun ortalaması 50 den büyükse iyi değilse kötü yazan uygulama
            Console.WriteLine("1. Notu giriniz");
            byte not1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("2. Notu giriniz");
            byte not2 = Convert.ToByte(Console.ReadLine());
            float sonuc = (not1 + not2) / 2;
            //> < >= <= == !=
            if (sonuc>=50)
            {
                Console.WriteLine("iyi");
            }
            else
            {
                Console.WriteLine("kötü");
            }
            Console.ReadLine();
        }
    }
}
