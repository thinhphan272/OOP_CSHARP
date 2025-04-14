using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_VeNha
{
    internal class MonDoAn : MonHoc
    {

        private double diemGVHD;
        
        private double diemGVPB;

        public double DiemGVHD
        {
            get { return diemGVHD; }
            set { diemGVHD = value; }
        }

        public double DiemGVPB
        {
            get { return diemGVPB; }
            set { diemGVPB = value; } 
        }

        public MonDoAn() : base() { }
        public MonDoAn(double diemGVHD, double diemGVPB, string maNH, string tenMH, int soTC, string khoaPhuTrach) : base(maNH, tenMH, soTC, khoaPhuTrach)
        {
            DiemGVHD = diemGVHD;
            DiemGVPB = diemGVPB;
        }
        public override double diemTB()
        {
            return (diemGVHD * 2 + diemGVPB) / 3;
        }


        public override double hocPhiMon()
        {
            return 2000000;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Điểm GVHD: {0}", DiemGVHD);
            Console.WriteLine("Điểm GVPB: {0}", DiemGVPB);
        }
    }
}
