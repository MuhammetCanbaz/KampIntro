using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //do not repeat yourself = kendini tekrarlama
            //kategoriEtiketi değer tutucu, aliasdır. Artık bizim için değeri var.

            string kategoriEtiketi = "Kategori";
            int ogranciSayisi = 320000000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true; //True ve False verilir.
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            //bool örneği
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
