using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiThucHanhCsharp28._3._2019
{
    class SachGiaoKhoa
    {   
        //Khai bao thuoc tinh
        private int MaSach;
        private int NgayNhap;
        private int DonGia;
        private int SoLuong;
        private int TinhTrang;
        private int TienSach;

       // public SachGiaoKhoa(int MaSach, int NgayNhap, int DonGia, int SoLuong, int TinhTrang, int TienSach)
       // {
         //   this.MaSach = MaSach;
         //   this.NgayNhap = NgayNhap;
         //   this.DonGia = DonGia;
         //   this.SoLuong = SoLuong;
         //   this.TinhTrang = TinhTrang;
        //    this.TienSach = TienSach;
       // }
            //Khai bao phuong thuc
            public void NhapThongTinSach()
        {   //Nhap ma sach
            Console.Write("\n--------Nhap sach giao khoa------------");
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
            //Nhap Tinh Trang
            
                Console.Write("\n----------Tinh trang sach---------");
                Console.Write("\n1.Sach moi");
                Console.Write("\n2.Sach cu");
            do
            {
                Console.Write("\nNhap tinh trang sach:");
                TinhTrang = int.Parse(Console.ReadLine());

                if (TinhTrang < 1 || TinhTrang > 2)
                {
                    Console.Write("\nNoi dung khong hop le. moi nhap lai tinh trang: ");
                }
            } while (TinhTrang < 1 || TinhTrang > 2);

            
            //Nhap Don gia
            Console.Write("\nNhap don gia: ");
            DonGia = int.Parse(Console.ReadLine());
            //Nhap so luong
            Console.Write("\nNhap so luong: ");
            SoLuong = int.Parse(Console.ReadLine());
            //Tien sach
            if(TinhTrang == 1)
            {
                TienSach = SoLuong * DonGia;
            }
            else
            {
                TienSach = SoLuong * DonGia * 50 / 100;
            }


    }
        public void HienThiSach()
        {
            Console.Write("\n-----------------Hien Thi Sach Giao Khoa :------------------");
            Console.Write("\n Ma sach :{0}", MaSach);
            Console.Write("\n Ngay nhap: {0}", NgayNhap);
            Console.Write("\n Don gia: {0}", DonGia);
            Console.Write("\n So luong sach: {0}", SoLuong);
            Console.Write("\n Tinh trang sach :{0}", TinhTrang);
            Console.Write("\n Tien sach: {0}", TienSach);
        }
    }
}
