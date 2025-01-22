using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama11_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while parantez içi true olana kadar döner
            // fordan en önemli farkı mantıksal operatör kullanılması
            // 1 den 10 a kadar toplamını bulan uygulama

            int i = 1;
            int toplam = 0;
            while(i<=10)
            {
                toplam += i;
                i++;
            }

            while(true)
            {
                i++;
                if(i==17)
                {
                    break;
                 }
                Console.WriteLine(i);
            }
            Console.WriteLine("sonuc: " + toplam);
            Console.ReadLine();
        }
    }
}
