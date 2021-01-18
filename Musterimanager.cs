using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Musterimanager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Eklendiniz! "  + "\n" + "Detaylariniz:" + "\n" + "Adi:" + musteri.Adi + "\n" + "Soyadi:" + musteri.Soyadi + "\n" + "Id:" + musteri.Id+ "\n" + "TC Kimlik no:" + musteri.Tckimlik);
            Console.WriteLine("--------------------------------------------------------------------");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Adi: " + musteri.Adi  + "\n" + "Soyadi: " + musteri.Soyadi  + "\n" + "Id:" + musteri.Id  + "\n" + "TC Kimlik no: " + musteri.Tckimlik);
            Console.WriteLine("--------------------------------------------------------------------");
        }

        public void Silme(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id +" Id numarali "  +  musteri.Adi  + musteri.Soyadi + " Musteri Bilgisi Silindi");
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
