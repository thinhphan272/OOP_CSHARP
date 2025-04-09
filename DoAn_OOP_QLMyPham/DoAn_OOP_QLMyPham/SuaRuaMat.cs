using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAn_OOP_QLMyPham
{
    public class SuaRuaMat : SanPham
    {
        public SuaRuaMat() { }
        public SuaRuaMat(string maSP, string tenSP, double trongLuong, double giaBan, string xuatXu, DateTime ngaySX) : base(maSP, tenSP, trongLuong, giaBan, xuatXu, ngaySX)
        { 


        }

        //Nhập thông tin sản phẩm SỬA RỬA MẶT
       
        public override void NhapSP()
        {
            Console.WriteLine("\n-------Nhập thông tin sản phẩm SỬA RỬA MẶT-------");
            base.nhap();
            
        }


        //Xuất thống tin sản phẩm SỬA RỬA MẶT
        public override void XuatSP()
        {
            Console.WriteLine("\n-------SẢN PHẨM SỬA RỬA MẶT-------");
            base.xuat();
        }

    }
}