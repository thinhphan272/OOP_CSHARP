using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_SVTuLam
{
    internal class HD_KhachHangCaNhan : HoaDon
    {

        private double khoangCachGH;

        public double KhoangCachGH
        {
            get { return khoangCachGH; }
            set { khoangCachGH = value; }
        }
        
        public HD_KhachHangCaNhan(): base() { }

        public HD_KhachHangCaNhan(double khoangCachGH, string maKH, string tenKH, int soLuong, double giaBan) : base(maKH, tenKH, soLuong, giaBan)
        {
            KhoangCachGH = khoangCachGH;
        }

        public override double tinhChietKhau()
        {
            if (SoLuong < 5)
                return 0;
            else if (SoLuong >= 5 && khoangCachGH < 10)
                return (double)0.03 * (SoLuong * GiaBan) + 20000 * SoLuong;
            else
                return (double)0.03 * (SoLuong * GiaBan);


        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Khoảng cách giao hàng: {0}", KhoangCachGH);
        }

            

    }
}
