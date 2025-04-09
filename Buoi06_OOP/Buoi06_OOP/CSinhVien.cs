using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi06_OOP
{
    public class CSinhVien : CPerson
    {
        private string maSV;
        private string chuyenNganh;
        private double diemTBTL;

        public CSinhVien()
        {

        }

        public CSinhVien(string maSV, string chuyenNganh, double diemTBTL, string hoTen, string gioiTinh, DateTime ngaySinh): base(hoTen,gioiTinh,ngaySinh)
        {
            this.maSV = maSV;
            this.chuyenNganh = chuyenNganh;
            this.diemTBTL = diemTBTL;
        }

     

        public override void nhapTT()
        {
            Console.WriteLine("Nhập thông tin sinh viên: ");
            base.nhap();
            Console.WriteLine("Nhập mã số sinh viên: ");
            maSV = Console.ReadLine();
            Console.WriteLine("Nhập chuyên ngành: ");
            chuyenNganh = Console.ReadLine();
            Console.WriteLine("Điểm trung bình tích lũy: ");
            diemTBTL = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + " " + maSV + " " + chuyenNganh + " " + diemTBTL;
        }
    }

    
}