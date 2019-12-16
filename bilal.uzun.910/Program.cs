using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilal.uzun._910
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, sayac = 1;
            char cevap = 'e';

            while (cevap == 'e')
            {
                Console.WriteLine("{0}. Sayıyı girin.", sayac);
                toplam += Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Devam istiyor musu?(e,h)");
                cevap = Convert.ToChar(Console.ReadLine());

                sayac++;
            }

            Console.WriteLine("Sonuç={0}", toplam);
            Console.ReadLine();
            Console.ReadKey();
        }
        
    }
}
