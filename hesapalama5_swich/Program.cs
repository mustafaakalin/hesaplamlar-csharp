using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapalama5_swich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kontrol mekanızması switch case(durum kontrolü)
            //
            Console.WriteLine("1. sayıyı giriniz");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            secim:
            Console.WriteLine("Toplama işlemi için 1\nÇıkarma için 2 \nÇarpama işlemi 3\nBölme için 4 'e basınız");
            byte secim=Convert.ToByte(Console.ReadLine());
            int sonuc;
            switch (secim)
            {
                case 1:
                   sonuc = sayi1 + sayi2;
                 break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    break;
                case 4:
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    Console.WriteLine("hatalı giriş yaptınız");
                    goto secim;
            }
            Console.WriteLine("işlem sonucu: "+sonuc);

            Console.ReadLine();
            

        }
    }
}
