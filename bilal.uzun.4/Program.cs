using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilal.uzun._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sayi = 0;
            while (true)
            {
                Console.Write("Sayıyı Girin : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                {
                    break;
                }

                if (sayi % 2 == 0)
                {
                    toplam += sayi;
                }
                else
                {
                    toplam -= sayi;
                }
            }

            Console.WriteLine("========================");
            Console.WriteLine("Sonuç : {0}", toplam);
            Console.ReadKey();
        }
    }
}
