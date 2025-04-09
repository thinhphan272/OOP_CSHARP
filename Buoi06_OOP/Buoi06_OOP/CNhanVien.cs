using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi06_OOP
{
    public class CNhanVien : CPerson
    {
        private string maNV;
        private string chucVu;
        private double heSoLuong;

        public CNhanVien()
        {

        }

        public CNhanVien(string maNV, string chucVu, double heSoLuong, string hoTen, string gioiTinh, DateTime ngaySinh):base(hoTen,gioiTinh,ngaySinh)
        {
            this.maNV = maNV;
            this.chucVu = chucVu;
            this.heSoLuong = heSoLuong;
        }
        public override void nhapTT()
        {
            base.nhap();
        }

        public bool xetTangLuong()
        {
            if (heSoLuong < 3.99)
                return true;
            return false;
        }
    }
}