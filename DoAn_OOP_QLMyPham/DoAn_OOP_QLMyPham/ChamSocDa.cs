using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAn_OOP_QLMyPham
{
    public class ChamSocDa : SanPham
    {
        public ChamSocDa() { }
        public ChamSocDa(string maSP, string tenSP, double trongLuong, double giaBan, string xuatXu, DateTime ngaySX) : base(maSP, tenSP, trongLuong, giaBan, xuatXu, ngaySX)
        {


        }

        //Nhập thông tin sản phẩm CHĂM SÓC DA
        public override void NhapSP()
        {
            Console.WriteLine("\n-------Nhập thông tin sản phẩm CHĂM SÓC DA-------");
            base.nhap();

        }

        //Xuất thông tin sản phẩm CHĂM SÓC DA
        public override void XuatSP()
        {
            Console.WriteLine("\n-------SẢN PHẨM CHĂM SÓC DA-------");
            base.xuat();
        }
    }
}