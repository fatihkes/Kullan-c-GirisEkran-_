using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıGirisEkranı_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "fatihkes";
            string email = "fatihkess0@gmail.com";
            string password = "123456";

            Console.WriteLine("Kullanıcı / E-mail Giriniz");
            Console.WriteLine("<<<====================>>>");
            string name = Console.ReadLine();
            Console.WriteLine("Parolanızı Giriniz");
            Console.WriteLine("<<<====================>>>");
            string sifre = Console.ReadLine();
            bool durum = (username == name || email == name) && password == sifre;
            Console.WriteLine(durum);
            if (durum == false)
            Console.WriteLine("Giriş Başarısız Tekrar Deneyiniz");
            else Console.WriteLine("Giriş Başarılı");
            Console.WriteLine("<<<====================>>>");
            Console.ReadLine();
        }
    }
}
