using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullnıcının girdiği 5 sayıyı gösteren uygulama
            int i = 1;
            while(i<=5)
            {
                Console.WriteLine(i+". Sayıyı giriniz");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayı :"+sayi);
                i++;
            }

            Console.ReadLine();
        }
    }
}
