using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();
            musteri1.id = 1;
            musteri1.ad = "Abdülmuttalib";
            musteri1.soyad = "GÜLER";
            musteri1.tc = "11111111111";
            musteri1.paraMiktari = 170000;

            Musteri musteri2 = new Musteri();
            musteri2.id = 1;
            musteri2.ad = "Melih";
            musteri2.soyad = "BATTAL";
            musteri2.tc = "22222222222";
            musteri2.paraMiktari = 150000;

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("1-Müşterileri listeye ekle");
            Console.WriteLine("1-Müşterileri listele");
            Console.WriteLine("1-Müşterileri listeden sil");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Seçim: ");
            int secim=Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    musteriManager.Ekleme(musteri1);
                    musteriManager.Ekleme(musteri2);
                    break;

                case 2:
                    musteriManager.Listeleme(musteri1);
                    Console.WriteLine("----------------------------------------------------");
                    musteriManager.Listeleme(musteri2);
                    break;
                
                case 3:
                    musteriManager.Silme(musteri1);
                    musteriManager.Silme(musteri2);
                    break;
            }
        }
    }
}
