using System;
                   //Gerçek Müsteri-Tüzel Müşteri
                   //SOLID
namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ömer";
            musteri1.Soyadi = "Duman";
            musteri1.TcNo = "123455677";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "4645";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "11111111111";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
