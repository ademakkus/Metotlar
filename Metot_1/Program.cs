using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string metin = MesajYaz();
            MesajYaz();
            Console.WriteLine(MesajYaz());
            Console.ReadKey();
        }
        /// <summary>
        /// Ekrandan girilen değeri geri döndürür.
        /// parametre almıyor.
        /// </summary>
        /// 
        /// <returns>strin değer döndürür.</returns>
         static string MesajYaz()
        {


            return Console.ReadLine();
        }
    }
}
