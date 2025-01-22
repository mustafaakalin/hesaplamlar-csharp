using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random: rasgele değer üretmek
            //random bir classtır .net kütüphanesinden
            // classtan nesne üretmek
            Random rasgelesayi = new Random();
           
            for (int i = 0; i < 5; i++)
            {               
                int sayi = rasgelesayi.Next(10, 50);
                Console.WriteLine(sayi);
            }
                        Console.ReadLine();
        }
    }
}
