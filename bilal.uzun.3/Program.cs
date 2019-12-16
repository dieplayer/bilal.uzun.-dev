using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilal.uzun._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Random rdn = new Random();
            int rastgele = rdn.Next(0, 10);
            while (true)
            {
                Console.Write("Sayı Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == rastgele)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(i + ". tahmininizde sayıyı buldunuz.");
            Console.ReadKey();
        }
    }
}
