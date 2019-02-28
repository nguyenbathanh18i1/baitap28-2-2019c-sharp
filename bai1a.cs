using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, s1 = 0, i;
            Console.Write("nhap n1:\n");
            n1= Convert.ToInt32(Console.ReadLine());

            
            for(i=1; i<=n1; i++)
            {
                if (i % 2 == 1) { s1 = s1 + i; }
                else { s1 = s1 - i; }
            }
            
           
            Console.Write("tong cac so nhap {0} \n", s1);
            Console.ReadKey();
        }
    }
}
