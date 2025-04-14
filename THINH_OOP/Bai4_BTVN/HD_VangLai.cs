using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_BTVN
{
    internal class HD_VangLai : HoaDon
    {
        public HD_VangLai() : base() { }
        public HD_VangLai(string maSo, string hoTenKhach, string ngayLap, MatHang matHang, int soLuong) : base(maSo, hoTenKhach, ngayLap, matHang, soLuong)
        {

        }

        public override double tinhKhuyenMai()
        {
            if ((SoLuong * MatHang.GiaBan) > 1000000)
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
