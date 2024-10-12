using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirisDersi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write Komutu tanıtıldı

            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Enes Aktaş");
            Console.WriteLine(2);

            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();

            Console.Write("SmartPro'ya");
            Console.WriteLine(" Hosgeldiniz");

            //Değişkenler

            string metin = "SmartPro'ya Hosgeldiniz!!!";
            Console.WriteLine(metin);

            string adSoyad = "Enes Aktaş";
            Console.WriteLine(adSoyad);

            string ad = "Bayram";
            string soyad = "Coskun";
            Console.WriteLine(ad + " " + soyad);


            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();

            string isim = "Bayram";
            string soyIsım = "Coskun";

            Console.WriteLine("Benim adım " + isim + " soyadım ise " + soyIsım);


            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();

            int sayi = 0;
            Console.WriteLine(sayi);

            int yas = 25;
            Console.WriteLine(yas);

            int sayi1 = 10;
            int sayi2 = 7;
            int sayi3 = 19;

            Console.WriteLine(sayi1 + " " + sayi2);

            Console.WriteLine("Benim yaşım : " + yas);

            //Birinci sayi = 10 , İkinci sayi = 7 , Üçüncü sayi = 19

            Console.WriteLine("Birinci sayi : " + sayi1 + " İkinci sayi : " + sayi2 + " Üçüncü sayi : " + sayi3);

            /*Birinci sayi = 10
             * İkinci Sayi = 7
             * Üçüncü sayi = 19 */

            Console.WriteLine("\nBirinci sayi : " + sayi1 + "\nİkinci Sayi : " + sayi2 + "\nÜçüncü Sayi : " + sayi3);

            int rakam1 = 5;
            int rakam2 = 9;
            int rakam3 = 7;
            int sonuc = rakam1 + rakam2 + rakam3;

            Console.WriteLine("Bu üç sayının toplamı : " + sonuc);


            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();

            /*Ad Soyad = Enes Aktas ,
             * Yaş = 25 ,
             * Memleket = Elazığ ,
             * CepNo = 132154*/

            string nameSurname = "Enes Aktaş";
            int age = 25;
            string homeTown = "Elazığ";
            string phoneNumber = "123456789";

            Console.WriteLine("Ad Soyad = " + nameSurname + "\nYaş = " + age + "\nMemleket = " + homeTown + "\nCepNo = " + phoneNumber);










            Console.ReadKey();
        }


    }
}
