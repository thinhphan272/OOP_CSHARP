using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_BTVN
{
    public abstract class HoaDon
    {
        protected string maSo;
        protected string hoTenKhach;
        protected string ngayLap;
        protected MatHang matHang;
        protected int soLuong;
        

        

        public string MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }

        public string HoTenKhach
        {
            get { return hoTenKhach; }
            set { hoTenKhach = value; }
        }

        public string NgayLap
        {
            get { return ngayLap;}
            set { ngayLap = value; }
        }    

        public MatHang MatHang
        {
            get { return matHang; }
            set {  matHang = value; }
        }
        
        
        public int SoLuong
        {
            get { return soLuong;}
            set { soLuong = value; }
        }

        public HoaDon() 
        {
            MaSo = "None";
            HoTenKhach = "None";
            ngayLap = "None";
            MatHang = new MatHang();
            SoLuong = 0;
        }

        public HoaDon(string maSo, string hoTenKhach, string ngayLap, MatHang matHang, int soLuong)
        {
            MaSo = maSo;
            HoTenKhach = hoTenKhach;
            NgayLap = ngayLap;
            MatHang = matHang;
            SoLuong = soLuong;
        }

        public abstract double tinhKhuyenMai();

        public double tinhTriGia()
        {
            return (double)SoLuong * MatHang.GiaBan - tinhKhuyenMai();

        }    

        public virtual void Xuat()
        {
            Console.WriteLine("| {0, -10} | {1, -25} | {2, -10} | {3, -6} |", maSo, hoTenKhach, ngayLap, soLuong);
            Console.WriteLine("------Mặt hàng------");
            Console.WriteLine("| {0, -10} | {1, -25} | {2, -10} |", MatHang.MaHang, MatHang.TenHang, MatHang.GiaBan);
        }    


    }
}
