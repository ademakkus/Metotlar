using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int left, top;
            Console.Write("yatay değer :");
            left = int.Parse(Console.ReadLine());
            Console.Write( "dikey konum : " );
            top = int.Parse(Console.ReadLine());
            Cursorposition(left, top);
                       
            Console.ReadKey();
        }

        /// <summary>
        /// İmleci ekranın ortasına konumlandıran metot
        /// </summary>
        /// <param name="left">yatay pozisyon</param>
        /// <param name="top">dikey pozisyon</param>
        static void Cursorposition(int left,int top)
        {
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < left; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("konum {0} ,{1}", left, top);
        }
    }
}
