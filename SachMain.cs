using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiThucHanhCsharp28._3._2019
{
    class SachMain
    {
        public void HienThiDanhSach()
        {
            int n;
            Console.WriteLine("\nnhap so sach:");
            n = Int32.Parse(Console.ReadLine());
            SachGiaoKhoa[] sgk = new SachGiaoKhoa[n];
            for (int i = 0; i < n; i++)
            {
              sgk[i] = new SachGiaoKhoa();
              sgk[i].NhapThongTinSach();
              sgk[i].HienThiSach();
            }
        }


    }
}
