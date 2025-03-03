namespace Lesson1_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Personel.cs dosyasındaki Personel sınıfını burada kullanabiliriz.
            //Program.cs dosyası Personel sınıfına erişebilir çünkü aynı namespace içerisinde bulunuyorlar.
            //.cs=> C# dosyası olduğunu belirtir ve C Sharp (C#) baş harflerini alarak yazılmıştır
            Personel getirPersonel = new Personel(); //instance alma işlemi yapılır.personel sınıfından getirPersonel adında bir nesne oluşturuldu.

            getirPersonel.PersonelEkle("Yasin", "Bağrıaçık",   "102893123");// Personel ekleme işlemleri

            getirPersonel.PersonelListele();// Personel listeleme işlemleri

            getirPersonel.PersonelGuncelle();// Personel güncelleme işlemleri

            getirPersonel.PersonelSil();// Personel silme işlemleri


            Console.WriteLine("---------Personel-1------------------------------------");
            getirPersonel.PersonelEkle("Yasin", "Bağrıaçık", "11 25 55");//Field ve Property lerin değerlerini atamak için kullanılır.
            getirPersonel.PersonelGuncelle();
            getirPersonel.PersonelSil();
            getirPersonel.PersonelListele();

            Console.WriteLine("---------Personel-2------------------------------------");

            getirPersonel.PersonelAdi = "Ali";
            getirPersonel.PersonelSoyadi = "Hecivelioğulları";
            getirPersonel.Number = 123;
            getirPersonel.Adres = "İstanbul-Kartal";
            getirPersonel.Telefon = "0544 456 78 90";
            getirPersonel.PersonelEkle(getirPersonel.PersonelAdi, getirPersonel.PersonelSoyadi, getirPersonel.Telefon);

            Console.WriteLine("---------Personel-3------------------------------------");

            getirPersonel.PersonelAdi = "Osman";
            getirPersonel.PersonelSoyadi = "Yılmaz";
            getirPersonel.Number = 124;
            getirPersonel.Adres = "İstanbul-Kadıköy";
            getirPersonel.Telefon = "0544 456 78 91";
            getirPersonel.PersonelEkle(getirPersonel.PersonelAdi, getirPersonel.PersonelSoyadi, getirPersonel.Telefon);





        }
    }
}
