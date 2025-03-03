namespace Lesson2_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructor=> Yapıcı metot
            //Constructor=> Bir sınıfın instance alındığı zaman çalışan metotlardır.
            //her class ın constructor methodu vardır ama kullanıcı tanımlı değilse default olarak çalışır.

            //class ilk çağrıldığında (instance edildiğinde) constructor çalışır.
            Kullanicilar kullanicilar = new Kullanicilar();
            //class çağrılırken bazı kurallar belirtmek ihtiyaç duyulduğunda constructor kullanılır.
            Kullanicilar kullaniciParametre1 = new Kullanicilar("Yasin");
            Kullanicilar kullaniciParametre2 = new Kullanicilar("Yasin", "abc_!78");
            // Kullanicilar kullaniciParametre3 = new Kullanicilar("Yasin","abc_!78","");


            Console.ReadLine();

        }
    }
}
