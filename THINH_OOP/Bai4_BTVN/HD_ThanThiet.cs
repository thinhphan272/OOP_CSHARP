using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_BTVN
{
    internal class HD_ThanThiet : HoaDon
    {
        public HD_ThanThiet() :base() { }
        public HD_ThanThiet(string maSo, string hoTenKhach, string ngayLap, MatHang matHang, int soLuong) : base(maSo, hoTenKhach, ngayLap, matHang, soLuong)
        {

        }

        public override double tinhKhuyenMai()
        {
            if (SoLuong > 60)
                return 0.04 * MatHang.GiaBan;
            else if (SoLuong <= 60 && (SoLuong * MatHang.GiaBan) >= 800000)
                return 0.03 * SoLuong * MatHang.GiaBan;
            else
                return 0;
        }

        public override void Xuat()
        {
            base.Xuat();
        }
    }
}
