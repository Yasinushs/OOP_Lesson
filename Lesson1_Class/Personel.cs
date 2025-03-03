using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Class
{
    internal class Personel
    {
        //Erişim Belirleyiciler
        /*
         1- public: Her yerden erişilebilir.
         2- private: Sadece tanımlandığı sınıf içerisinden erişilebilir.
         3- protected: Sadece tanımlandığı sınıf içerisinden ve bu sınıftan türetilen sınıflardan erişilebilir.
         4- internal: Sadece tanımlandığı proje içerisinden erişilebilir.
         5- protected internal: protected ve internal erişim belirleyicilerinin birleşimidir. Tanımlandığı sınıf içerisinden, bu sınıftan türetilen sınıflardan ve tanımlandığı proje içerisinden erişilebilir.

         */

        //CRUD İşlemleri=> Create(Insert), Read (List), Update, Delete
        //eğer method için erişim belirleyici tanımlanmazsa oto olarak private  tanımlanır, eğer class için erişim belirleyici tanımlanmazsa oto olarak internal tanımlanır.
        internal void PersonelEkle(string isim, string soyisim,string telefon)
        {             //Personel ekleme işlemleri
            PersonelAdi = isim;
            PersonelSoyadi = soyisim;
            Telefon = telefon;
            Console.WriteLine("Personel Eklendi: " + PersonelAdi + " " + PersonelSoyadi + " " + Telefon);
        }

        public void PersonelListele()
        {             //Personel listeleme işlemleri
        }

        public void PersonelGuncelle()
        {             //Personel güncelleme işlemleri
        }

        protected internal void PersonelSil()
        {             //Personel silme işlemleri
        }


        //field ve propertyler
        //Field: Class içerisinde tanımlanan değişkenlere denir.
        //Property: Field'ların değerlerini atamak ve okumak için kullanılır.


        public string PersonelAdi;
        public string PersonelSoyadi;
        public int Number;
        public string Adres;
        public string Telefon;
    }
}
