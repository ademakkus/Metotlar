using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_2_Alan_Hesapla_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alan hesaplanacak şekli seçiniz:  \n1- Üçgen,  \n2-Kare  \n3-Dikdörtgen   ");
            Console.Write("\nSeçenek : ");
            int secenek;
            int ucgenyukseklik, ucgenkenar;
            int karekenar;
            int dikdörtgenkisakenar, dikdortgenuzunkenar;
            double sonuc = 0;
            secenek = int.Parse(Console.ReadLine());
            switch (secenek)
            {
                #region Üçgen Alan Hesaplama
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Üçgen yükseklik giriniz : "); ucgenyukseklik = int.Parse(Console.ReadLine());
                    Console.Write("üçgen taban kenarını giriniz : "); ucgenkenar = int.Parse(Console.ReadLine());
                    sonuc = UcgenAlanHesapla(ucgenyukseklik, ucgenkenar);
                    Console.WriteLine("Üçgennin alanı : {0}", sonuc);
                    break; 
                #endregion
                #region Kare alan hesaplama
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("karenin kenarını giriniz : "); karekenar = int.Parse(Console.ReadLine());
                  
                    sonuc = KareAlanHesapla(karekenar);
                    Console.WriteLine("karenin alanı : {0}", sonuc);
                    break; 
                #endregion
                #region Dikdörtgen Alan Hesaplama
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Dikdörtgen kısa kenarını giriniz : "); dikdörtgenkisakenar = int.Parse(Console.ReadLine());
                    Console.Write("Dikdörtgen uzun kenarını giriniz : "); dikdortgenuzunkenar = int.Parse(Console.ReadLine());
                    sonuc = DikdortgenAlanHesapla(dikdortgenuzunkenar, dikdörtgenkisakenar);
                    Console.WriteLine("Dikdörtgenin alanı : {0}", sonuc);
                    break; 
                #endregion
                default:
                    break;
            }
           
            Console.ReadKey();
        }
        /// <summary>
        /// Dikdörtgenin alanını hesaplayan metot.
        /// </summary>
        /// <param name="dikdortgenuzunkenar">dikdörtgen uzun kenar uzunluğu</param>
        /// <param name="dikdörtgenkisakenar">dikdörtgen kısa  kenar uzunluğu</param>
        /// <returns>double sonuç döndürmekte</returns>
        private static double DikdortgenAlanHesapla(int dikdortgenuzunkenar, int dikdörtgenkisakenar)
        {
            double sonuc = dikdörtgenkisakenar * dikdortgenuzunkenar;
            return sonuc;
        }
        /// <summary>
        /// Karenin alanını hesaplar
        /// </summary>
        /// <param name="karekenar">kare kenar uzunluğu</param>
        /// <returns></returns>
        private static double KareAlanHesapla(int karekenar)
        {
            double sonuc = karekenar * karekenar;
            return sonuc;
        }
        /// <summary>
        /// Üçgenin alanını hesaplayan metot
        /// </summary>
        /// <param name="ucgenyukseklik">üçgen yükseklik değeri</param>
        /// <param name="ucgenkenar">üçgentaban kenar değeri</param>
        /// <returns></returns>
        private static double UcgenAlanHesapla(int ucgenyukseklik, int ucgenkenar)
        {
            int alan = (ucgenkenar / 2) * ucgenyukseklik;
            return alan;
        }


    }
}
