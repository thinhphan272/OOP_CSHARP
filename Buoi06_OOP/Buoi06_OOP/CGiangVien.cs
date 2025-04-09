using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_OOP
{
    public class CGiangVien : CPerson
    {
        private string maGV;
        private string trinhDo;
        private double heSoLuong;

        public CGiangVien()
        {

        }

        public CGiangVien(string maGV, string trinhDo, double heSoLuong)
        {
            this.maGV = maGV;
            this.trinhDo = trinhDo;
            this.heSoLuong = heSoLuong;
        }

       

        public override void nhapTT()
        {
            Console.WriteLine("Nhập thông tin giảng viên");
            base.nhap();
            Console.WriteLine("Nhập mã giảng viên: ");
            maGV = Console.ReadLine();
            Console.WriteLine("Nhập trình độ: ");
            trinhDo = Console.ReadLine();
            Console.WriteLine("Nhập hệ số lương: ");
            heSoLuong = double.Parse(Console.ReadLine());

        }

        public override string ToString()
        {
            return base.ToString() + " "  + maGV + "_" + trinhDo + " " + heSoLuong;
        }

        public bool xetTangLuong()
        {
            if (heSoLuong < 3.99)
                return true;
            return false;
        }
    }
}
