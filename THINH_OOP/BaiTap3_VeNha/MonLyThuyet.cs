using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_VeNha
{
    internal class MonLyThuyet : MonHoc
    {
        private double diemTieuLuan;

        public double DiemTieuLuan
        {
            get { return diemTieuLuan; }
            set { diemTieuLuan = value; }
        }

        private double diemGiuaKy;
        public double DiemGiuaKy
        {
            get { return diemGiuaKy; }
            set { diemGiuaKy = value; }
        }

        private double diemCuoiKy;

        public double DiemCuoiKy
        {
            get { return diemCuoiKy; }
            set { diemCuoiKy = value; }
        }

        public MonLyThuyet() : base() { }

        public MonLyThuyet(double diemTieuLuan, double diemGiuaKy, double diemCuoiKy, string maNH, string tenMH, int soTC, string khoaPhuTrach) : base(maNH, tenMH, soTC, khoaPhuTrach)
        {
            DiemTieuLuan = diemTieuLuan;
           
            DiemGiuaKy = diemGiuaKy;
           
            DiemCuoiKy = diemCuoiKy;
        }

        public override double diemTB()
        {
            return DiemTieuLuan * 0.2 + DiemGiuaKy * 0.3 + DiemCuoiKy * 0.5;
        }

        public override double hocPhiMon()
        {
            return (double)SoTC * 250000;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Điểm tiểu luận (20%): {0}", DiemTieuLuan);
            Console.WriteLine("Điểm giữa kỳ (30%): {0}", DiemGiuaKy);
            Console.WriteLine("Điểm cuối kỳ (50%): {0}", DiemCuoiKy);
        }

    }
}
