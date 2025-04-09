using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAn_OOP_QLMyPham
{
    public class TayTrang : SanPham, IGiamGia
    {
        public TayTrang() { }
        public TayTrang(string maSP, string tenSP, double trongLuong, double giaBan, string xuatXu, DateTime ngaySX) : base(maSP, tenSP, trongLuong, giaBan, xuatXu, ngaySX)
        {


        }

        //Nhập thông tin sản phẩm TẨY TRANG
        public override void NhapSP()
        {
            Console.WriteLine("\n-------Nhập thông tin sản phẩm TẨY TRANG-------");
            base.nhap();

        }

        //Xuất thông tin sản phẩm TẨY TRANG
        public override void XuatSP()
        {
            Console.WriteLine("\n-------SẢN PHẨM TẨY TRANG-------");
            base.xuat();
        }

        //Phương thức giảm giá của sản phẩm TẨY TRANG

        public double GiamGia()
        {
            if (GiaBan > 200000)
                return GiaBan * 0.9; //Giảm 10%
            else if (GiaBan >= 100000 && GiaBan <= 200000)
                return GiaBan * 0.93;
            else
                return GiaBan * 0.95;
        }
    }
}