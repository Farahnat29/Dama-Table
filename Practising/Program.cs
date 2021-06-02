using AlanHesabi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesabi
{
    class Ogrenci
    {
        private string adi;
        private string soyadi;
        private DateTime dogumTarihi;
        private string memleket;
        private string numara;
        private string bolum;
        private string fakulte;
        public Ogrenci(string adi, string soyadi, DateTime dogumTarihi,
       string memleket, string numara, string bolum, string fakulte)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.dogumTarihi = dogumTarihi;
            this.memleket = memleket;
            this.numara = numara;
            this.bolum = bolum;
            this.fakulte = fakulte;
        }
        public void EkranaYazdir()
        {
            Console.WriteLine("Numarası : " + this.numara);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Adı : " + this.adi);
            Console.WriteLine("Soyadı : " + this.soyadi);
            Console.WriteLine("Doğum Tarihi : " +
           this.dogumTarihi.ToShortDateString());
            Console.WriteLine("Memleket : " + this.memleket);
            Console.WriteLine("Fakültesi : " + this.fakulte);
            Console.WriteLine("Bölümü : " + this.bolum);
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] arg)
        {

            // o1 isimli ilk öğrenci nesnesi oluşturuluyor
            Ogrenci o1 = new Ogrenci("Barış", "Çalışkan", new DateTime(1981,
           3, 1), "Sakarya", "0001.10001", "Bilgisayar Mühendisliği", "Mühendislik");
            //o1 nesnesi ekrana yazdırılıyor
            o1.EkranaYazdir();

            // o2 isimli ilk öğrenci nesnesi oluşturuluyor
            Ogrenci o2 = new Ogrenci("Ahmet", "Şanslı", new DateTime(1983, 8,
           17), "Sakarya", "0101.10001", "Bilgisayar Mühendisliği", "Mühendislik");

        }
    }
}


