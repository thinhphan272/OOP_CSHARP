using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_VeNha
{
    public abstract class MonHoc
    {
        protected string maMH;
        protected string tenMH;
        protected int soTC;
        protected string khoaPhuTrach;
        protected double diem;

        public string MaMH
        {
            get { return maMH;}
            set { maMH = value; }
        }

        public string TenMH
        {
            get { return tenMH;}
            set { tenMH = value; }  
        }

        public int SoTC
        {
            get { return soTC; }
            set { soTC = value; }
        }

        public string KhoaPhuTrach
        {
            get { return khoaPhuTrach;}
            set {  khoaPhuTrach = value;}
        }

        public MonHoc()
        {
            MaMH = "Chua biet";
            TenMH = "Chua biet";
            SoTC = 0;
            KhoaPhuTrach = "Chua biet";
        

        }

        public MonHoc(string maNH, string tenMH, int soTC, string khoaPhuTrach)
        {
            MaMH = maNH;
            TenMH = tenMH;
            SoTC = soTC;
            KhoaPhuTrach= khoaPhuTrach;
            
        }

        public abstract double hocPhiMon();
        public abstract double diemTB();
        public virtual void Xuat()
        {
            Console.WriteLine("\n| {0, -10} | {1, -25} | {2, -8} | {3, -30} | {4, -7} | {5, -15} |", MaMH, TenMH, SoTC, KhoaPhuTrach, Math.Round(diemTB(),2), hocPhiMon());
        }


    }
}
