using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAn_OOP_QLMyPham
{
    public class KemChongNang : SanPham, IGiamGia
    {

        public KemChongNang() { }
        //Khởi tạo KemChongNang (kế thừa tham số của class SanPham)
        public KemChongNang(string maSP, string tenSP, double trongLuong, double giaBan, string xuatXu, DateTime ngaySX) : base(maSP, tenSP, trongLuong, giaBan, xuatXu, ngaySX)
        {
            
        }

        //Nhập thông tin sản phẩm KEM CHỐNG NẮNG
        public override void NhapSP()
        {
            Console.WriteLine("\n-------Nhập thông tin sản phẩm KEM CHỐNG NẮNG-------");
            base.nhap();

        }

        //Xuất thông tin sản phẩm KEM CHỐNG NẮNG
        public override void XuatSP()
        {
            Console.WriteLine("\n-------SẢN PHẨM KEM CHỐNG NẮNG-------");
            base.xuat();
        }


        //Phương thức giảm giá của sản phẩm KEM CHỐNG NẮNG

        public double GiamGia()
        {
            int thangChenhLech = (DateTime.Now.Year - NgaySX.Year) * 12 + (DateTime.Now.Month - NgaySX.Month);
            if (thangChenhLech >= 12)
                return GiaBan * 0.9; //Giảm 10%
            else if (thangChenhLech >= 9)
                return GiaBan * 0.95; //Giảm 5%
            else
                return GiaBan * 0.97; //Giảm 3%
        }
    }
}