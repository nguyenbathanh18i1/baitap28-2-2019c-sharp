using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1d
{
    class Program
    {
        static void Main(string[] args)
        {

            int n4, s4 = 0;
            Console.Write("nhap n4:\n");
            n4 = int.Parse(Console.ReadLine());

            for (int i = 1; i < n4; i++)
            {
                if (n4 % i == 0)
                    s4 += i;
            }
            Console.WriteLine("Ket qua la: {0}", s4);
            Console.ReadLine();
        }
    }
}
