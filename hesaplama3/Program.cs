using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if yapısında aynı anda bakılması geren şart birden fazla olursa or yada And yapısı kullanılır
            // && ||
            //kullanıcının girdiği ad ve şifre doğru ise hoş geldiniz değilse hatalı giriş gösteren uyuglama
            string ad = "serap";
            string sifre = "12a";

            go:
            Console.Write("kullanıcı adınızı giriniz");
            string kullaniciAd=Console.ReadLine();
            Console.Write("kullanıcı şifrenizi giriniz");
            string kullaniciSifre=Console.ReadLine();

            if (ad == kullaniciAd && sifre == kullaniciSifre) {
                Console.WriteLine("hoşgeldin");
            }
            else
            {
                Console.WriteLine("hatalı giriş yaptın");
                goto go;
            }
            Console.ReadLine();
        }
    }
}
