using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager //ekleme - listeleme - silme
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi : " + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas);
        }

    }
}
