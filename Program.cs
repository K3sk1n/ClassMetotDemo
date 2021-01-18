using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mehmet Taha";
            musteri1.Soyadi = "Kaya";
            musteri1.Id = 1234;
            musteri1.Tckimlik = 12345678901;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Engin";
            musteri2.Soyadi = "Demirog";
            musteri2.Id = 4321;
            musteri2.Tckimlik = 10987654321;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ahmet";
            musteri3.Soyadi = "Karatas";
            musteri3.Id = 2314;
            musteri3.Tckimlik = 13579124680;

            Musterimanager musterimanager = new Musterimanager();
            musterimanager.Ekle(musteri1);
            musterimanager.Silme(musteri2);
            musterimanager.Listele(musteri3);
        }
    }
}
