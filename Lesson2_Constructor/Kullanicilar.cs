using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Constructor
{
    internal class Kullanicilar
    {
        //Constructor=> Yapıcı metot
        //Constructor method adı class adı ile aynı olmalıdır.
        //Constructor methodlar geriye değer döndürmezler.
        //Constructor methodlar void ile de tanımlanmazlar.
        //Constructor methodlar overload edilebilirler.
        public Kullanicilar()
        {
            //Constructor içerisine yazılan kodlar, sınıf new lendiğinde çalışır.
            //Constructor içerisine parametre gönderilebilir.
            //Constructor içerisine parametre gönderilirse, default constructor silinir.
            //Constructor ismi sınıf ismi ile aynı olmalıdır.
            //Constructor overloading yapılabilir.
            Console.WriteLine("ctor çalıştı");
            //loglama işlemleri
            //veritabanı işlemleri
            //token, session, cookie gibi geçici bellek işlemleri de bu alanda yapılabilir.
        }

        //ctor +tab+tab=> Constructor oluşturur.
        public Kullanicilar(string name)
        {

        }
       



        public Kullanicilar(string name, string password)
        {

        }
        public string KullaniciEkle(string kullaniciAdi, string sifre)
        {
            return kullaniciAdi + " " + sifre;
        }

        //Overloading=> Aşırı yükleme
        public void KullaniciListele()
        {
        }
        public void KullaniciListele(int kullaniciAdi)
        {
            //Ali leri listele araması yapabilir
        }

        void Islem(int sayi1)
        {

        }

        void Islem(int sayi1, int sayi2)
        {
        }

        void Islem(int sayi1, int sayi2, int sayi3)
        {
        }

    }
}
