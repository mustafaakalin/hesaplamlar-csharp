using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen  iki farklı sayıdan büyük olanı gösteren uygulama
            degeral:
            Console.WriteLine("1. sayıyı giriniz");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            //if(sayi1>sayi2)
            //{
            //    Console.WriteLine("birinci sayı büyüktür" + sayi1);
            //}
            //else {
            //    Console.WriteLine("ikinci sayı büyüktür" + sayi2);
            //}


            // iç içe if else kullanımı
            if (sayi1 == sayi2)
            {
                Console.WriteLine("lütfen farklı iki sayı giriniz");
                goto degeral;
                //Console.WriteLine("1. sayıyı giriniz");
                //int sayi3 = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("2. sayıyı giriniz");
                //int sayi4 = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                if (sayi1>sayi2)
                {

                    Console.WriteLine("birinci sayı büyük");
                }
                else
                {
                    Console.WriteLine("ikinci sayı büyük");
                }
            }
            Console.ReadLine();
        }
    }
}
