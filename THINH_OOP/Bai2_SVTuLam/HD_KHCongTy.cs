using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_SVTuLam
{
    internal class HD_KHCongTy : HoaDon
    {
        private int soLuongNV;
        public int SoLuongNV
        {
            get { return soLuongNV; }
            set { soLuongNV = value; }
        }

        public HD_KHCongTy() : base() { }

        public HD_KHCongTy(int soLuongNV, string maKH, string tenKH, int soLuong, double giaBan) : base(maKH, tenKH, soLuong, giaBan)
        {
            SoLuongNV = soLuongNV;
        }

        public override double tinhChietKhau()
        {
            if (SoLuongNV > 5000)
                return 0.05 * GiaBan;
            else if (SoLuongNV > 1000)
                return 0.03 * GiaBan;
            else
                return 0;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số lượng nhân viên: {0}", SoLuongNV);
        }
    }
}
