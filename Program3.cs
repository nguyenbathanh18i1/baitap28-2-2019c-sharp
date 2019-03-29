using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiThucHanhCsharp28._3._2019
{
    class Book
    {   //Khai bao thuoc tinh
        private int MaSach;
        private int NgayNhap;
        private int DonGia;
        private int SoLuong;

        //Khai bao phuong thuc
        public void NhapThongTinSach()
        {   //Nhap ma sach
            Console.Write("\nNhap Ma Sach: ");
            MaSach = int.Parse(Console.ReadLine());
            //Nhap ngay nhap
            do
            {
                Console.Write("\nNhap Ngay Nhap: ");
                NgayNhap = int.Parse(Console.ReadLine());

                if (NgayNhap < 0 || NgayNhap > 31)
                {
                    Console.Write("\nNgay nhap khong hop le (1-31).");
                }
            } while (NgayNhap < 0 || NgayNhap > 31);
            //Nhap Don gia
            Console.Write("\nNhap don gia: ");
            DonGia = int.Parse(Console.ReadLine());
            //Nhap so luong
            Console.Write("\nNhap so luong: ");
            SoLuong = int.Parse(Console.ReadLine());
        }
        public void HienThiSach()
        {
            Console.Write("\n-----------------Hien Thi Sach:------------------");
            Console.Write("\n Ma sach :{0}", MaSach);
            Console.Write("\n Ngay nhap: {0}", NgayNhap);
            Console.Write("\n Don gia: {0}", DonGia);
            Console.Write("\n So luong sach: {0}", SoLuong);
        }
    }
    class Program3
    {
        static void Main(string[] args)
        {
            Console.Write("\nCau a");
            Book sach1 = new Book();

            sach1.NhapThongTinSach();
            sach1.HienThiSach();

            Console.Write("\nCau b");
            SachGiaoKhoa sach2 = new SachGiaoKhoa();

            sach2.NhapThongTinSach();
            sach2.HienThiSach();

            Console.Write("\nCau c");
            SachMain sach3 = new SachMain();
            sach3.HienThiDanhSach();

            Console.ReadKey();
        }
    }
}
