using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_2_Alan_Hesapla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** KARENİN ALANINI HESAPLA *****");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Karenin kenar uzunluğunu giriniz : ");
            double kenaruzunlugu = double.Parse(Console.ReadLine());
            double alan=KareAlanHesapla(kenaruzunlugu);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nkenar uzunluğu : {0} olan karenin alanı : {1}",kenaruzunlugu,alan);
            Console.ReadKey();
        }

       private  static   double KareAlanHesapla(double kenar)
        {
            return kenar * kenar;
        }

    }
}
