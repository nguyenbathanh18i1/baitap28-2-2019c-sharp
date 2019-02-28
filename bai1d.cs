using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1d
{
    class Program
    {
        static void Main(string[] args)
        {
            int n4, s4 = 0;
           Console.Write("nhap n4:\n");
            n4 = int.Parse(Console.ReadLine());

            for(int i=1; i<= Math.Sqrt(n4); i++)
            {
                if (n4 % i ==0)
                {
                    int j = n4 / i;
                    if (i==j)
                    {
                        s4 = s4 + i;
                    }
                    else
                    {
                        s4 = s4 + i + j;
                    }
                }
            }
        }
    }
}
