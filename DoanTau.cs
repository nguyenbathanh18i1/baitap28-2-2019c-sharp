using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapthuchanh
{
    class doantau
    {
        string madoantau;
        int soluongkhach;
        public void nhaptt()
        {
            Console.WriteLine("nhap ma doan tau");
            this.madoantau = Console.ReadLine();
            Console.WriteLine("nhap so luong khach");
            this.soluongkhach = Convert.ToInt32(Console.ReadLine());
        }
        public float tongtien()
        {
            float tien;
            if (this.soluongkhach < 100)
                tien = this.soluongkhach * 100000;
            else
                tien = this.soluongkhach * 80000;
            return tien;
        }
        public void intau()
        {
            Console.WriteLine("ma doan tau{0} co tien la {1}", this.madoantau, this.tongtien());
            Console.ReadLine();
        }
    }
}