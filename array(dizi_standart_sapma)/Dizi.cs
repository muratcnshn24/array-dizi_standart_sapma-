using System;
using System.Collections.Generic;
using System.Text;

namespace array_dizi_standart_sapma_
{
    class Dizi
    {
        ///<sammary>
        /// tek boyutlu dizi oluşturmak için kullanılan fonksiyondur.
        ///</sammary>
        ///<param name="Limit"> dizinin uzunluğunu belirtir </param>
        ///<returns> belirtilen uzunlukta rastgele sayıyılardan oluşmuş diziyi döner  </returns>
        public int[] Olustur(int Limit)
        {
            int[] sayilar = new int[Limit];
            Console.WriteLine("");
            for (int i = 0; i < Limit; i++)
            {
                sayilar[i] = new Random().Next(1, 100);
                Console.WriteLine("{0,3}", sayilar[i]);
            }
            Console.WriteLine(""); // dizi karakterleri yan yana yazılsın diye alt ve üste bu kısmı yazıp diziyi  araya aldım
            return sayilar;

        }

        ///<sammary>
        ///  Parametre olarak aldığı dizideki en büyük elemanı döner.
        ///</sammary>
        ///<param name="Dizi"> Dizi </param>
        ///<returns></returns>
        public static int EnBuyuk(int[] dizi)
        {
            int eb = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > eb) eb = dizi[i];

            }
            return eb;
        }

        ///<sammary>
        ///  Parametre olarak aldığı dizideki en küçük elemanı döner.
        ///</sammary>
        ///<param name="Dizi"> Dizi </param>
        ///<returns></returns>
        public static int EnKucuk(int[] dizi)                  //statik yaparsan nesne üretmene gerek kalmaz
        {
            int ek = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < ek) ek = dizi[i];

            }
            return ek;
        }
        ///<sammary>
        /// ParametrE olarak aldığı dizinin aritmetik ortalamasını hesaplar ve döner.
        ///</sammary>
        ///<param name="X">Dizi</param>
        ///<returns>Aritmetik Ortalama</returns>

        public static double AritmetikOrtalama(int[] X)
        {
            double toplam = 0;
            for (int i = 0; i < X.Length; i++)
            {
                toplam += X[i];
            }
            return toplam / X.Length;
        }


        ///<sammary>
        ///  Parametre olarak aldığı dizinin standar sapmasini hesaplar.
        ///</sammary>
        ///<param name="X"> Dizi </param>
        ///<returns>Standart Sapma</returns>

        public static double StandartSapma(int[] X)
        {
            double aritmetikOrtalama = AritmetikOrtalama(X);
            double t = 0, f = 0;

            for (int i = 0; i < X.Length; i++)
            {
                f = X[i] - aritmetikOrtalama;
                t += Math.Pow(f, 2);             //Pow üst alma fonksiyonudur.

             
                        
            }
            return Math.Sqrt(t / (X.Length - 1)); // Sqrt karakök fonksiyonu.
        }
    }
}
