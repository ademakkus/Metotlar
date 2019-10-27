using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_5_Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, faktoriyel;
            //
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Faktöriyeli alınacak sayıyı giriniz : ");
            sayi = int.Parse(Console.ReadLine());
            faktoriyel = FaktoriyelHesapla(sayi);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n{0} ! sayısının faktöriyel değeri: {1}", sayi, faktoriyel);

            Console.ReadKey();
        }
        /// <summary>
        /// klavyeden girilen sayının faktöriyelini  döndüren metot.
        /// </summary>
        /// <param name="sayi">faktöriyeli alınacak sayı</param>
        /// <returns>int değer döndürür.</returns>
        private static int FaktoriyelHesapla(int sayi)
        {
            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;

            }
            return sonuc;
        }
    }
}
