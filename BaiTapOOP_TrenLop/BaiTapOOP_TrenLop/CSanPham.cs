using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP_TrenLop
{
    internal class CSanPham
    {
        private string tenSp;
        private double donGia;
        private double giamGia;



        //Constuctor mặc định
        public CSanPham() { }

        //Constructor tham số
        public CSanPham(string tenSp, double donGia, double giamGia)
        {
            this.tenSp = tenSp;
            this.donGia = donGia;
            this.giamGia = giamGia;
        }


        //Constructor copy
        public CSanPham(CSanPham sp)
        {
            tenSp = sp.tenSp;
            donGia = sp.donGia;
            giamGia = sp.giamGia;   
        }

        //Property
        public string TenSp
        {
            get => tenSp;
            set => tenSp = value;
        }
        public double DonGia
        {
            get => donGia;
            set => donGia = value;
        }
        public double GiamGia
        {
            get => giamGia;
            set => giamGia = value;
        }



        public double TinhThueNhapKhau()
        {

            return donGia * 0.1;
        }

        public void xuat()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Tên sản phẩm: {tenSp}");
            Console.WriteLine($"Đơn giá: {donGia} VNĐ");
            Console.WriteLine($"Giảm giá: {giamGia} VNĐ");
            Console.WriteLine($"Thuế nhập khẩu: {TinhThueNhapKhau()} VNĐ");
            Console.WriteLine("-------------------------------");
        }
    }
}
