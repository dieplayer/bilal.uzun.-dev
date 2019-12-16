using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilal.uzun._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 30, toplam = 0;
            while (sayi >= 0)
            {
                Console.Write("Bir sayı giriniz....>");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                {
                    toplam += sayi;
                }
            }
            Console.WriteLine("Girdiniz sayıların Toplamı = {0}", toplam);
            Console.ReadKey();
        }
    }
}
