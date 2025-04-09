using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace BaiTap_Buoi06
{
    public abstract class CCaPhe
    {
        private string maLoai;
        private string tenLoai;
        private int soLuong;
        private double donGia;

        public CCaPhe()
        {
            
        }

        public CCaPhe(string maLoai, string tenLoai, int soLuong, double donGia)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public virtual void nhap()
        {
            Console.WriteLine("Nhập mã loại: ");
            maLoai = Console.ReadLine();
            Console.WriteLine("Nhập tên loại: ");
            tenLoai = Console.ReadLine();
            Console.WriteLine("Nhập số lượng: ");
            soLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập đơn giá: ");
            donGia = double.Parse(Console.ReadLine());
        }

        public abstract void nhapTT();

        public override string ToString()
        {
            return maLoai + "_" + tenLoai + "_" + soLuong + "_" + donGia;
        }
    }
}