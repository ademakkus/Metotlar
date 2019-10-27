using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int us, taban;
            //
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Üs değerini giriniz: ");
            us = int.Parse(Console.ReadLine());
            Console.Write("Taban değerini giriniz: ");
            taban = int.Parse(Console.ReadLine());
            double sonuc = UsAl(us, taban);

            //
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("\nSonuc :{0}",sonuc);
           Console.ReadKey();
        }
        //<summary> unutma!!!!
        /// <summary>
        /// Klavyeden üs değeri kadar tabanın kuvvetini alır
        /// </summary>
        /// <param name="us"> üs değeri</param>
        /// <param name="taban">taban değeri</param>
        /// <returns> double değer döndürür</returns>
        private static double UsAl(int us,int taban)
        {
            int sonuc=1;
            for (int i = 1; i <=us; i++)
            {
                sonuc*=taban;
            }
          
            return sonuc;
          
        }
    }
}
