using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_SVTuLam
{
    public abstract class HoaDon
    {
        protected string maKH;
        protected string tenKH;
        protected int soLuong;
        protected double giaBan;
        public static double phanTramVAT = 0.1;
        public string MaKH
        {
            get { return maKH; } 
            set { maKH = value; }
        }

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public double GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        public HoaDon()
        {
            MaKH = "Chua biet";
            TenKH = "Chua biet";
            SoLuong = 0;
            GiaBan = 0;
            
        }

        public HoaDon(string maKH, string tenKH, int soLuong, double giaBan)
        {
            MaKH = maKH;
            TenKH = tenKH;
            SoLuong = soLuong;
            GiaBan = giaBan;
        }

        public abstract double tinhChietKhau();

        public double tinhThanhTien()
        {
            return (double)SoLuong * GiaBan - tinhChietKhau() + (phanTramVAT * (SoLuong * GiaBan));
        }

        public virtual void Xuat()
        {
            Console.WriteLine("{0, -10} {1, -25} {2, -6} {3, -15:N0} {4, -15:N0}", MaKH, TenKH, SoLuong, GiaBan, tinhThanhTien());
        }

    }
}
