using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eğitim durumuna göre lise ve orta öğretim için 3000 önlisans ve lisans için 5000 yükseklisans için 6000
            Console.WriteLine("Eğitim durumunuz ortaöğretim için 1\nLise için 2\nÖnlisans için 3\nLisans için 4\nYükseklisans için 5 ya basınız");
            byte secim=Convert.ToByte(Console.ReadLine());
            switch (secim)
            {
                case 1:
                case 2:
                    Console.WriteLine("3000 tl burs kazandın");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("5000 tl ");
                    break;
                case 5:
                    Console.WriteLine("6000 tl");
                    break;
                default:
                    Console.WriteLine("hatalı giriş");
                    break;
            }
            Console.ReadLine();
        }
    }
}
