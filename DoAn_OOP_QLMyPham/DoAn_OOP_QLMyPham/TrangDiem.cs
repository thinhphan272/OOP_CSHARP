using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAn_OOP_QLMyPham
{
    public class TrangDiem : SanPham
    {

        public TrangDiem() { }

        public TrangDiem(string maSP, string tenSP, double trongLuong, double giaBan, string xuatXu, DateTime ngaySX) : base(maSP, tenSP, trongLuong, giaBan, xuatXu, ngaySX)
        {


        }
        //Nhập thông tin sản phẩm TRANG ĐIỂM
        public override void NhapSP()
        {
            Console.WriteLine("\n-------Nhập thông tin sản phẩm TRANG ĐIỂM-------");
            base.nhap();

        }

        //Xuất thông tin sản phẩm TRANG ĐIỂM
        public override void XuatSP()
        {
            Console.WriteLine("\n-------SẢN PHẨM TRANG ĐIỂM-------");
            base.xuat();
        }
    }
}