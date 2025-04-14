using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_VeNha
{
    internal class MonThucHanh : MonHoc
    {
        private double cot1;
        private double cot2;
        private double cot3;
        private double cot4;

        public double Cot1
        {
            get { return cot1; }
            set { cot1 = value; }
        }    

        public double Cot2
        {
            get { return cot2; }
            set { cot2 = value; }
        }    

        public double Cot3
        {
            get { return cot3; }
            set { cot3 = value; }
        }

        public double Cot4
        {
            get { return cot4; }
            set { cot4 = value; }   
        }    

        public MonThucHanh(): base() { }

        public MonThucHanh(double cot1, double cot2, double cot3, double cot4, string maNH, string tenMH, int soTC, string khoaPhuTrach) : base(maNH, tenMH, soTC, khoaPhuTrach)
        {
            Cot1 = cot1;
            Cot2 = cot2;
            Cot3 = cot3;
            Cot4 = cot4;
           
        }

        public override double diemTB()
        {
            
            return (cot1 + cot2 + cot3 + cot4) / 4;
        }

        public override double hocPhiMon()
        {
            return (double)SoTC * 350000 + 100000;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("-----4 cột điểm-----");
            Console.WriteLine("{0, -5} {1, -5} {2, -5} {3, -5}", Cot1, Cot2, Cot3, Cot4);
        }

    }
}
