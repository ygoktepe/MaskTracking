using System;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer("Yasin");
            SelamVer("Ahmet");
            SelamVer("Ayşe");
            SelamVer();


            int sonuc = Topla(6, 58);


            //Arrays

            string ogrenci1 = "Yasin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Yasin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            foreach (string i in ogrenciler)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }


        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+ sonuc.ToString());
            return sonuc;
        }
        private static void Degiskenler()
        {
            string mesaj = "Hello";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Yasin";
            string soyad = "Göktepe";
            int dogumYili = 1995;
            long tcNo = 12345678910;
            2.37

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
