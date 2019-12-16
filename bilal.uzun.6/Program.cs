using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilal.uzun._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 1;
            while (sayi != 0)
            {
                Console.WriteLine("bir sayı girin..:");
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Bitti");
            Console.ReadLine();
        }
    }
}
