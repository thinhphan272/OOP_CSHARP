using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_BTVN
{
    internal class HD_VIP : HoaDon
    {
        public HD_VIP():base() { }

        public HD_VIP(string maSo, string hoTenKhach, string ngayLap, MatHang matHang, int soLuong) : base(maSo, hoTenKhach, ngayLap, matHang, soLuong )
        {

        }    
        public override double tinhKhuyenMai()
        {
            if (SoLuong > 50)
                return 0.05 * MatHang.GiaBan;
            else if (SoLuong <= 50 && (SoLuong * MatHang.GiaBan) >= 600000)
                return 0.04 * SoLuong * MatHang.GiaBan;
            else if (SoLuong >= 10)
                return 0.01 * SoLuong * MatHang.GiaBan;
            else
                return 0;
        }

        public override void Xuat()
        {
            base.Xuat();
        }
    }
}
