using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1c
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, sum=0, n;

            Console.Write("\nNhap so phan tu:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");

            for(j=1; j<=n; j++)
            {
                sum = sum + j;
                
            }
            Console.Write("Tong cua day {0} so bang {1}\n", n, sum);
            Console.ReadKey();
        }
    }
}
