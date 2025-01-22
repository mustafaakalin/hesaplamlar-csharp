using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rastgele üretilen 20 sayıdan çift olanların toplamını gösterne uygulama
            Random rnd = new Random();
            int toplam=0;
            for (int i = 1; i <= 20; i++)
            {
                int sayi = rnd.Next(1, 100);
                Console.WriteLine(sayi);
                if (sayi % 2 == 0)
                {
                    toplam += sayi;
                }
                
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
