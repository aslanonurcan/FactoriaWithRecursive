using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoriawithlRecursion
{
    class Program
    {
        public static int sonuc;
        static void Main(string[] args)
        {           
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rescursive : {0} ", FaktoriyelRecursive(n));
            Console.ReadKey();
        }
        static int FaktoriyelRecursive(int sayi)
        {
            if (sayi > 1)
            {
                sonuc = sayi * FaktoriyelRecursive(sayi-1);
                return sonuc;
            }
            else
            {
                return sayi;
            }
        }
    }
}
