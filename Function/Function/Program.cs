using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dikdörtgenin Alanı: " + dHesap(20,2));
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Karenin Alanı: " + kHesap(20));
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Üçgenin Alanı: " + üHesap(10,2));
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Dairenin Alanı: " + daireHesap(20,2));
            Console.ReadKey();
        }

        static int dHesap(int kk , int uk)
        {
            int alan = kk * uk;
            return alan;
        }
        static int kHesap(int kare)
        {
            int alan = kare * kare;
            return alan;
        }
        static int üHesap(int yüksek , int taban)
        {
            int alan = taban * yüksek / 2;
            return alan;
        }

        static int daireHesap(int r, int pi)
        {
            int alan = pi * r * r;
            return alan;
        }
    }
}
