using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = "Enver";
            musteri.Soyad = "Can";
            musteri.Yas = 20;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Ali";
            musteri2.Yas = 21;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Hasan";
            musteri3.Soyad = "Ali";
            musteri3.Yas = 22;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("-------------------------------");

            musteriManager.Listele(musteri);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            Console.WriteLine("-------------------------------");

            musteriManager.Sil(musteri);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
        }
    }
}
