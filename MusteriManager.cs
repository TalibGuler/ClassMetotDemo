using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
        public void Ekleme(Musteri musteri)
        {
              Console.WriteLine(musteri.tc+" TC numaralı " +musteri.ad+" "+ musteri.soyad+" listeye eklendi." );
        }

        public void Listeleme(Musteri musteri)
        {
            Musteri[] musteriler = new Musteri[] {musteri};
            foreach (var item in musteriler)
            {
                Console.WriteLine("Adı: " + item.ad);
                Console.WriteLine("Soyadı: " + item.soyad);
                Console.WriteLine("TC: " + item.tc);
                Console.WriteLine("Para Miktarı: " + item.paraMiktari);
            }

        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.tc + " TC numaralı " + musteri.ad + " " + musteri.soyad + " listeden silindi.");
        }

        
    }
}
