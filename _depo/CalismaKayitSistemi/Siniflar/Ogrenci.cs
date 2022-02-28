using System;
using System.Collections.Generic;

namespace CalismaKayitSistemi.Siniflar
{
     
    class Ogrenci : Kisi, IkBahseden
    {
        //Kisi kisi;
        private string _no; // field ile öğrenci no yu değişime kapadım dışardan.(kapsülleme bu)
        public string Bolum { get; set; }
        public List<Ders> AldigiDersler { get; set; }

        //ctor yazdık Mainde öğrenci bilgilerini doğru girebilmek için.
          public Ogrenci(string no,string tcNo,string adSoyad) 
          : base(tcNo, adSoyad) //üst sınıfın ctor unun çalıştırdık :base() ile yazdığımız kısımla.
        {
            _no = no;
            AldigiDersler = new List<Ders>();
           // this.kisi = new Kisi(tcNo, adSoyad); //bunu mainde değil burada tanımlaman lazım.Amaç object ile bağlantılı  şekilde tutmak.
                           //üst satıtı niye iptal etti bilmiyorum.olmadı yine.       
                               
        }

        public override void KendindenBahset()
        {
            Console.WriteLine($"{_tcNo} - {_adSoyad} - {_no} - {Bolum}");

        }
        

    }

}