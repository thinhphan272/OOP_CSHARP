using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THINH_OOP
{
    internal class NhanVienKD : NhanVienABC
    {
        private double ds_toiThieu;
        private double ds_thucTe;

        public double Ds_toiThieu
        {
            get { return ds_toiThieu; }
            set { ds_toiThieu = value;}
        }    

        public double Ds_thucTe
        {
            get { return ds_thucTe; }
            set { ds_thucTe = value;}
        }    
        public NhanVienKD() : base(){ }
        public NhanVienKD(double ds_toiThieu, double ds_thucTe, string maNV, string tenNV, int namSinh, string gioiTinh, double heSoLg, int namVL) : base(maNV, tenNV, namSinh, gioiTinh, heSoLg, namVL)
        {
            Ds_toiThieu = ds_toiThieu;
            Ds_thucTe = ds_thucTe;
        }

        public override double Luong()
        {
            if (Ds_thucTe > Ds_toiThieu)
                return HeSoLg * LuongCB + ((Ds_thucTe - Ds_toiThieu) * 0.15);
            else
                return HeSoLg * LuongCB;
        }

        public override char XepLoai()
        {
            if (Ds_thucTe > Ds_toiThieu * 2)
                return 'A';
            else if (Ds_thucTe >= Ds_toiThieu)
                return 'B';
            else
            {
                if (Ds_thucTe < 0.5 * Ds_toiThieu)
                    return 'D';
                else
                    return 'C';
            } 
                
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("KPI: {0}\nDS Thực tế: {1}", Ds_toiThieu, Ds_thucTe);
        }


    }
}
