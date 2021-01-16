using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ??


            int[] sayyilar1 = new int[] { 10, 20, 30 };
            int[] sayyilar2 = new int[] { 10, 20, 30 };
            sayyilar1 = sayyilar2;
            sayyilar2[0] = 000;
            //sayilar[0]
        }

        //int,double, float ----- değer tiplerdir.
        //class, arrayler ----- referans tiplerdir
        //

    }
}
