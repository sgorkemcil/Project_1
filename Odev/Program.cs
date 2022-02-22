using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Market<Urun> market = new Market<Urun>();
            market.UrunEkle(new Bulgur { UrunID = 23, UrunAdi = " Pilavlık ", Fiyat = 10 , TETT = DateTime.Parse(" 25/02/2022") });
            market.UrunEkle(new CamBardak { UrunID = 44, UrunAdi = "6 lı su bardağı", Fiyat = 35, Kirik = true });
            market.UrunEkle(new CamBardak { UrunID = 48, UrunAdi = "6 lı su bardağı", Fiyat = 25, Kirik = false });
            market.UrunEkle(new KagitHavlu { UrunID = 11, UrunAdi = " Kagit Havlu ", Fiyat = 37 });
            market.UrunEkle(new Sut { UrunID = 55, UrunAdi = "1lt sut", Tipi = "Keci", Fiyat = 15, SKT = DateTime.Parse("18/02/2022") });
            market.UrunEkle(new Yumurta { UrunID = 32, UrunAdi = " 15 li yumurta", Fiyat = 25 , Kirik = true, SKT = DateTime.Parse("19/02/2022") });
            market.UrunEkle(new Yumurta { UrunID = 33, UrunAdi = " 30 li yumurta", Fiyat = 33 , Kirik = false, SKT = DateTime.Parse("28/02/2022") });

            //Urun Listele
            foreach (var item in market.TumUrunler())
            {
                Console.WriteLine(item);
            }

            //Kirik Urunler
            Console.WriteLine("Kırık Urunler");
            foreach (var item in market.KirikUrunler())
            {
                Console.WriteLine(item);
            }



            //Bozulan Urunler
            Console.WriteLine("Bozuk Urunler");
            foreach (var item in market.BozukUrunler())
            {
                Console.WriteLine(item);

            }
        }
    }
}