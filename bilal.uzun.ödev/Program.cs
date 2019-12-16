using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilal.uzun.ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi >= 0)
            {
                Console.WriteLine(sayi);
                System.Threading.Thread.Sleep(1000);
                sayi--;
            }
            Console.ReadKey();
        }
    }
}
